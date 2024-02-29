using UnityEngine;
using System.Collections.Generic;

public class CustomPiece : MonoBehaviour
{
    public enum TypeCreation{
        Piece, // Single standard piece added to human
        RegionsParent, // Disabled regions parent to be enabled when needed
        PieceToReplace // Piece grouping other pieces. When they get enabled, should disable the grouped pieces
    }
    public TypeCreation Type;

    public List<string> zAnatomyIds;

    public void GetData(){
        zAnatomyIds = new List<string>();

        List<GameObject> list = new List<GameObject>();

        switch(Type){
            case CustomPiece.TypeCreation.Piece:
                // All references for children IDs
                // list = new List<MeshRenderer>(GetComponentsInChildren<MeshRenderer>());
                // GetChildRecursive(gameObject, list);

                foreach (GameObject child in list){
                    zAnatomyIds.Add(child.name);
                }
                break;

            case CustomPiece.TypeCreation.RegionsParent:
                // Find all inmmediate children inside this object and make a list

                // GetChildRecursive(gameObject, list);
                // List<SphereCollider> listMeshRenderers = new List<SphereCollider>(GetComponentsInChildren<SphereCollider>());
                
                foreach (Transform child in transform){
                    zAnatomyIds.Add(child.name);
                }
                break;

            case CustomPiece.TypeCreation.PieceToReplace:
                // Get only MeshInteractive children and save their IDs to replace
                // GetChildRecursive(gameObject, list);

                List<ZAnatomy.MeshInteractiveController> listMeshRenderers = new List<ZAnatomy.MeshInteractiveController>(GetComponentsInChildren<ZAnatomy.MeshInteractiveController>());

                foreach (ZAnatomy.MeshInteractiveController child in listMeshRenderers){
                    zAnatomyIds.Add(child.name);
                }

                break;
        }
    }
}