using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ZAnatomy{
    public static class ZAnatomyUtils{

        public static GameObject UpdateMeshInteractive(GameObject resultObject, ZAnatomy.ZAnatomyController.OrganType BodyPart, string FinalID){
            MeshInteractiveController meshInteractive = resultObject.GetComponent<MeshInteractiveController>();
            if(meshInteractive == null){
                meshInteractive = resultObject.AddComponent<MeshInteractiveController>();
            }

            // meshInteractive.Path = Path;
            // meshInteractive.Depth = Depth;
            meshInteractive.BodyType = ZAnatomyUtils.GetStringFromBodyPartEnum(BodyPart);
            meshInteractive.Path = "/"+meshInteractive.BodyType+"/" + FinalID;
            meshInteractive.BodyPart = BodyPart;//ZAnatomyUtils.GetOrganTypeFromPart(BodyPart);
            // meshInteractive.UpdateCustomMaterials(transparentMaterial);
            meshInteractive.Morgue_Init();
            // meshInteractive.DividedPrefab = DividedPrefab;
            meshInteractive.UpdateCollider();
            meshInteractive.CanBeGrabbed = true;

            // CreatedPiece = meshInteractive;

            // GameObject parentResult = GameObject.Find("CustomCreations");
            resultObject.transform.SetParent(null, true);

            return resultObject;
        }

        public static void DestroyAllChildren(Transform parent){
            for (int i = parent.childCount; i > 0; --i)
                GameObject.DestroyImmediate(parent.GetChild(0).gameObject);
        }

        public static void CloneMeshAndSave(GameObject meshObject, string assetPath){
            MeshFilter meshFilter = meshObject.GetComponent<MeshFilter>();
            Mesh originalMesh = meshFilter.sharedMesh; //1
            Mesh clonedMesh = new Mesh(); //2

            clonedMesh.name = meshObject.name;//+"-DividedPiece";
            clonedMesh.vertices = originalMesh.vertices;
            clonedMesh.triangles = originalMesh.triangles;
            clonedMesh.normals = originalMesh.normals;
            clonedMesh.uv = originalMesh.uv;
            
            List<UnityEngine.Rendering.SubMeshDescriptor> submeshesList= new List<UnityEngine.Rendering.SubMeshDescriptor>();

            for(int i = 0; i< originalMesh.subMeshCount; i++){
                submeshesList.Add(originalMesh.GetSubMesh(i));
            }
            clonedMesh.SetTriangles(clonedMesh.triangles, 0);
            clonedMesh.subMeshCount = originalMesh.subMeshCount;
            clonedMesh.SetSubMeshes(submeshesList.ToArray());

            // string path = m_SelectedPath+"/"+MeshesFolderName+"/"+clonedMesh.name.Trim()+".asset";
            // string assetPath = ZAnatomyUtils.GetAssetPathFromFullPath(path);
            // Debug.Log("Created cloned mesh on: "+assetPath);
            //AssetDatabase.CreateAsset(clonedMesh, assetPath);
            //AssetDatabase.SaveAssets();

            meshFilter.sharedMesh = clonedMesh;
            meshFilter.GetComponent<MeshCollider>().sharedMesh = clonedMesh;
        }
        
        public static string UpperFirstChar(string str){
            return char.ToUpper(str[0]) + str.Substring(1);
        }
        
        // Copied from OVRCommon
        public static Transform FindChildRecursiveInChildren(this Transform parent, string name)
        {
            foreach (Transform child in parent)
            {
                if (child.name.Trim().Equals(name.Trim()))
                    return child;

                var result = child.FindChildRecursiveInChildren(name.Trim());
                if (result != null)
                    return result;
            }
            return null;
        }

        public static int GetDepthFromPath(string path){
            return path.Split('/').Length - 1;
        }

        private static void CheckConnectedObjects(bool useKDTree, ZAnatomy.MeshInteractiveController original, List<ZAnatomy.DataList.DataModel> connectedModels,  List<ZAnatomy.DataList.DataModel> fullList, float radiusNeighbours, string layerMask = ""){

            Vector3 p1;
            Vector3 p2;
            Vector3 originalPosCloseToCenter;
            Vector3 colliderPosCloseToCenter;

            //float lastClosestDistance = -1;
            if(useKDTree){
                p1 = original.GetMeshKDTree().ClosestPointOnSurface(original.GetCenterPosition());
            }else{
                p1 = original.Collider.ClosestPoint(original.GetCenterPosition());
            }
            //ResourcesDataProfile.DataList.DataModel closestConnectedObject = null;
            foreach(ZAnatomy.DataList.DataModel colliderDataModel in fullList){
                if(colliderDataModel.Model != original){
                    
                    if(useKDTree){
                        p2 = colliderDataModel.Model.GetMeshKDTree().ClosestPointOnSurface(p1);//colliderDataModel.Model.GetCenterPosition());
                    }else{
                        p2 = colliderDataModel.Model.Collider.ClosestPoint(p1);//colliderDataModel.Model.GetCenterPosition());
                    }

                    Vector3 centerPosition = (p1 + p2)*0.5f;
                    if(useKDTree){
                        originalPosCloseToCenter = original.GetMeshKDTree().ClosestPointOnSurface(centerPosition);
                        colliderPosCloseToCenter = colliderDataModel.Model.GetMeshKDTree().ClosestPointOnSurface(centerPosition);
                    }else{
                        originalPosCloseToCenter = original.Collider.ClosestPoint(centerPosition);
                        colliderPosCloseToCenter = colliderDataModel.Model.Collider.ClosestPoint(centerPosition);
                    }

                    float distanceBetweenClosestPoint = Vector3.Distance(originalPosCloseToCenter, colliderPosCloseToCenter);
                    //Debug.Log("Raycast "+colliderDataModel.Model.gameObject.activeInHierarchy +" - "+original.gameObject.activeInHierarchy);
                    
                    //if(lastClosestDistance!= -1){
                        bool isNeighbour = false;// distanceBetweenClosestPoint <= lastClosestDistance;
                        RaycastHit raycast;
                        LayerMask mask;
                    /* if(!string.IsNullOrEmpty(layerMask)){
                            mask = LayerMask.NameToLayer(layerMask);
                        }else{*/
                            mask = ~0;
                        //}
                        
                        //Debug.DrawLine(originalPosCloseToCenter, (colliderPosCloseToCenter-originalPosCloseToCenter).normalized * radiusNeighbours, Color.red, Mathf.Infinity);
                        if(Physics.Raycast(originalPosCloseToCenter, colliderPosCloseToCenter-originalPosCloseToCenter, out raycast, radiusNeighbours, mask)){
                            if(raycast.collider.gameObject == colliderDataModel.Model.gameObject)
                                isNeighbour = true;
                        }
                        
                        if(Physics.Raycast(colliderPosCloseToCenter, originalPosCloseToCenter-colliderPosCloseToCenter, out raycast, radiusNeighbours, mask)){
                            if(raycast.collider.gameObject == original.gameObject)
                                isNeighbour = true;
                        }

                        /*if(colliderDataModel.Name.Equals("Rib7"))
                            Debug.DrawLine(originalPosCloseToCenter, colliderPosCloseToCenter, isNeighbour?Color.green:Color.red, Mathf.Infinity);
                        */

                        if(isNeighbour){
                            connectedModels.Add(colliderDataModel);

                        }
                    /*}else{
                        if(distanceBetweenClosestPoint < lastClosestDistance){
                            lastClosestDistance = distanceBetweenClosestPoint;
                        }
                    }*/

                }
            }

            //return -1;//lastClosestDistance;
        }

        public static void SetAllModelsCollider(bool enable, List<ZAnatomy.DataList.DataModel> fullList ){
            foreach (ZAnatomy.DataList.DataModel item in fullList)
            {
                item.Model.SetCollider(enable);
            }
        }
        public static ZAnatomy.ZAnatomyController.OrganType GetOrganTypeFromPart(string BodyPart){
            string[] PieceTypeNames = System.Enum.GetNames (typeof(ZAnatomy.ZAnatomyController.OrganType));
            for(int i = 0; i < PieceTypeNames.Length; i++){
                if(BodyPart.ToLower().Contains(PieceTypeNames[i].ToLower())){
                    return (ZAnatomy.ZAnatomyController.OrganType)i;
                }
            }

            return ZAnatomy.ZAnatomyController.OrganType.NotRecognized;
        }

        public static string GetStringFromBodyPartEnum (ZAnatomyController.OrganType BodyPart)
        {
            string name = "";

            switch (BodyPart)
            {
                case ZAnatomyController.OrganType.Body:
                    name = "Regions of human body.g_LOW_25";
                    break;
                case ZAnatomyController.OrganType.Skeletal:
                    name = "Skeletal system.g_LOW_80_70";
                    break;
                case ZAnatomyController.OrganType.Nervous:
                    name = "Nervous system & Sense organs.g_LOW_80";
                    break;
                case ZAnatomyController.OrganType.Joints:
                    name = "Joints.g_LOW_80";
                    break;
                case ZAnatomyController.OrganType.Cardiovascular:
                    name = "Cardiovascular system.g_LOW_80_85";
                    break;
                case ZAnatomyController.OrganType.Visceral:
                    name = "Visceral systems.g_LOW_80";
                    break;
                case ZAnatomyController.OrganType.Muscular:
                    name = "Muscular system.g_LOW_80_70";
                    break;
            }
            
            return name;
        }

        public static string GetIDModelFromPath(string Path){
            string[] splittedPath = Path.Split("/");
            return splittedPath[splittedPath.Length-1];
        }

        public static string GetAssetPathFromFullPath(string path){
            return path.Substring(path.IndexOf("Assets"));
        }

    }
}