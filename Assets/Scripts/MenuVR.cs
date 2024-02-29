using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuVR : MonoBehaviour
{
    public Animator FadeOut;
    public GameObject FadeNegro;
    public GameObject esferaInicio;
    public GameObject referencia;
    public ScenesInformation scenesInformation;
    public Transform scene;
    public float mano;
    public GameObject mano1;
    public GameObject mano2;
    public GameObject mano3;
    //public bool cambioEscena = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(eliminarBola());
        //referencia = GameObject.FindWithTag("Center");
        scene.position = ScenesInformation.instancia.TargetPosition;
        //scene.rotation = new Quaternion(ScenesInformation.instancia.rotationX, ScenesInformation.instancia.rotationY, ScenesInformation.instancia.rotationZ, scene.rotation.w);
        scene.rotation = Quaternion.Euler(ScenesInformation.instancia.TargetRotation);
        //scene.rotation = Quaternion.Euler(scene.eulerAngles.x, ScenesInformation.instancia.VRreference.eulerAngles.y +180, scene.eulerAngles.z);

        //scene.rotation = Quaternion.Euler(0f, -90f, 0f);
        mano = ScenesInformation.instancia.opMano;
        if (mano == 0)
        {
            //mano1.SetActive(true);
            //mano2.SetActive(false);
            //mano3.SetActive(false);
        }
        if(mano== 1)
        {
            //mano1.SetActive(false);
            //mano2.SetActive(true);
            //mano3.SetActive(false);

        }
        if (mano == 2)
        {
            //mano1.SetActive(false);
            //mano2.SetActive(false);
            //mano3.SetActive(true);
        }

        //scenesInformation=referencia.GetComponent<ScenesInformation>();
        //scene.position = scenesInformation.TargetPosition;
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        //FadeNegro.SetActive(true);
        //FadeOut.Play("FadeOut");
        if (other.CompareTag("E1"))
        {
            //FadeOut.SetBool("CambioEscena",true);
            //cambioEscena = true;
            // El objeto tiene el tag "miTag"
            Debug.Log("Holi toque el cubo");
            //SceneManager.LoadScene("SampleScene");
            //StartCoroutine(CambioEscenaDiana());
            ScenesInformation.instancia.esferaTransitions.SetActive(true);

            StartCoroutine(cambioEscena(2));
            //ScenesInformation.instancia.esferaTransitions.SetActive(true);
            //ScenesInformation.instancia.sceneSwitcherMenu(2);
        }
        if (other.CompareTag("E2"))
        {
            //cambioEscena = true;
            // El objeto tiene el tag "miTag"
            //Debug.Log("Holi");
            //SceneManager.LoadScene("AppBolitas");
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(cambioEscena(3));

        }
        if (other.CompareTag("E3"))
        {
            //cambioEscena = true;

            // El objeto tiene el tag "miTag"
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(cambioEscena(4));
            //Debug.Log("Holi");
            //SceneManager.LoadScene("AppBolitas2");
        }
        if (other.CompareTag("E4"))
        {

            //cambioEscena = true;
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(cambioEscena(5));
            // El objeto tiene el tag "miTag"
            //Debug.Log("Holi");
            //SceneManager.LoadScene("AppBisel2");
        }
        if (other.CompareTag("E5"))
        {

            //cambioEscena = true;
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(cambioEscena(6));
            // El objeto tiene el tag "miTag"
            //Debug.Log("Holi");
            //SceneManager.LoadScene("AppBisel2");
        }
    }
    IEnumerator CambioEscenaDiana()
    {
        yield return new WaitForSeconds(2);
            SceneManager.LoadScene("SampleScene");

    }
    IEnumerator eliminarBola()
    {
        yield return new WaitForSeconds(2);
        esferaInicio.SetActive(false);
    }
    IEnumerator cambioEscena(int scene)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
        
    }

    public void retartMethod()
    {
        SceneManager.LoadScene(0);
        //Destroy(GameObject.Find("OVRCameraRig"));
        //Destroy(GameObject.Find("SceneInformation"));


    }
}
