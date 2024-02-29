using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScenesInformation : MonoBehaviour
{
    public Transform marker;
    public float opMano;
    public float opPatientPosition;
    public float opFAT;
    public GameObject esferaTransitions;
    public GameObject esferaInicial;
    public GameObject videoRetroceso;
    public Transform VRreference;

    public Vector3 TargetPosition;
    //public Quaternion TargetRotation;

    public float rotationX;
    public float rotationY;
    public float rotationZ;
    public Vector3 TargetRotation;

    public bool sphereActiva;
   // public Quaternion targetRotation1;

 
    public Transform referenciaTransform;
    // public Dropdown scrolbarMano;

    public TMP_Dropdown scrolbarMano;
    public TMP_Dropdown scrolbarPatientPosition;

    public static ScenesInformation instancia;
    public GameObject centroRoom;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        instancia = this;
        sphereActiva = false;
    }
    private void Update()
    {
        if (sphereActiva == true)
        {
            StartCoroutine(quitarEsfera());
            sphereActiva = false;
        }
    }

    // Update is called once per frame
    public void guardarInfo()
    {
        TargetPosition=referenciaTransform.position;
        //targetRotation1 = Quaternion.Euler(TargetRotation);
        TargetRotation = referenciaTransform.eulerAngles; //new Vector3(referenciaTransform.eulerAngles.x,referenciaTransform.eulerAngles.y,referenciaTransform.eulerAngles.z);
        //targetRotation1 = Quaternion.Euler(TargetRotation);

        /*rotationX = referenciaTransform.rotation.x;
        rotationY = referenciaTransform.rotation.y;
        rotationZ = referenciaTransform.rotation.z;
        */

        /*rotationX=referenciaTransform.rotation.x;
        rotationY=referenciaTransform.rotation.y;
        rotationZ=referenciaTransform.rotation.z;
        TargetRotation=new Vector3(rotationX,rotationY,rotationZ);*/
        //TargetRotation = referenciaTransform.rotation;
        //marker.position = referenciaTransform.position;
        //marker.rotation = referenciaTransform.rotation;
        //marker.localScale = referenciaTransform.localScale;
        opMano = scrolbarMano.value;
        opPatientPosition = scrolbarPatientPosition.value;
    }

    public void comenzar()
    {
        guardarInfo();
        esferaTransitions.SetActive(true);
        //SceneManager.LoadScene(1);
        StartCoroutine(SceneSwitcher());
        //SceneManager.LoadScene(1);
    }
    IEnumerator SceneSwitcher()
    {
        Debug.Log("switcheron");
        yield return new WaitForSeconds(2);
        esferaInicial.SetActive(false);
        Debug.Log("Estoy dentro");
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(3);
        esferaTransitions.SetActive(false);

    }

    public void sceneSwitcherMenu(int scene)
    {
        Debug.Log("LLamo correctamente al sceneswitcher");
        esferaTransitions.SetActive(true);
        StartCoroutine(switcherTo(scene));
    }
    IEnumerator switcherTo(int scene)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
        centroRoom.SetActive(false);
        yield return new WaitForSeconds(3);
        esferaTransitions.SetActive(false);

    }
    public void videoRetrocesoOn()
    {
        videoRetroceso.SetActive(true);
    }
    public void videoRetrocesoOff()
    {
        videoRetroceso.SetActive(false);

    }

    IEnumerator quitarEsfera()
    {
        yield return new WaitForSeconds(3);
        esferaTransitions.SetActive(false);
    }


}
