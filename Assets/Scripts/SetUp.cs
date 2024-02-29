using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System.Globalization;

public class SetUp : MonoBehaviour
{
    //Texto con instrucciones
    public GameObject texto1;
    public GameObject texto2;
    public GameObject texto3;
    public GameObject texto4;
    public GameObject texto5;

    public GameObject imagenVRHaptico;
    public GameObject imagenop1;
    public GameObject imagenop2;
    public GameObject imagenop3;

    public GameObject titulo1;
    public GameObject titulo2;
    public GameObject titulo3;

    public GameObject eleccion;

    //Reposicionamiento de la sala
    public Transform cubo;
    public Transform mando;
    public Transform mandoReference;
    public Transform VRParent;

    public GameObject transicionLetras;

    public GameObject instruction2;

    public float velocidadRotacion = 1f;//velocidad rotation

    public SkinnedMeshRenderer manoR;
    public SkinnedMeshRenderer manoL;

    public Transform mireaqui;
    public Transform centroRoom;
    public Transform centroGafas;
    public GameObject centroRoomObject;
    //Veces que se ha pulsado espacio condicion
    public int pasos;
    // Start is called before the first frame update
    public GameObject menuSettings;
    public int openOrClose;
    public float rotationOffset;
    public Slider sliderOculusRotation;
    public TMP_InputField numeroEscrito;
    
    void Start()
    {
        Debug.Log("Hola start");
        pasos = 0;
        //manoR.enabled = false;
        manoL.enabled=false;
        StartCoroutine(centrarRoom());
        rotationOffset =-54;
        openOrClose = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&&pasos==0)//primer paso: colocación
        {
            Debug.Log("Funciona");
            transicionLetras.SetActive(true);
            StartCoroutine(transicion());
            //texto1.SetActive(false);
            //texto2.SetActive(false);
            //texto3.SetActive(true);
            //texto4.SetActive(true);
            //pasos = 1;
            //active la transicion de cambio de letras
            
        }
        if (Input.GetKey(KeyCode.Space) && pasos == 1)
        {
            reposicionarHaptico();
        }
        
    }
    public void reposicionarHaptico()
    {
        float rotationY = VRParent.eulerAngles.y + 180;//OLD CODE

        Vector3 vectorMandoHead = mando.position - VRParent.position;
        vectorMandoHead.y = 0;
        Vector3 vectorMandoHeadNormalizado = vectorMandoHead.normalized;
        float angle = Mathf.Atan2(vectorMandoHeadNormalizado.x, vectorMandoHeadNormalizado.z) + Mathf.Rad2Deg;
        rotationY = angle+rotationOffset;
 
        cubo.rotation = Quaternion.Euler(cubo.eulerAngles.x, rotationY, cubo.eulerAngles.z);
        Vector3 distanciaMandos = mando.position - mandoReference.position;
        cubo.position += distanciaMandos;
            //Debug.Log("Holiiii");
            //cubo.position = new Vector3 ((float)(mando.position.x+0.3),(float)(mando.position.y+0.1),(float)(mando.position.z-0.1));
        //cubo.position.x =mando.position.x+0.2;
       // cubo.position.y =mando.position.y+0.2;
        //cubo.position.z = mando.position.z - 0.1;4

        //cubo.rotation = Quaternion.Euler(0f, 180f, 0f);
            //cubo.rotation = new Quaternion(cubo.rotation.x, mando.rotation.y,cubo.rotation.z,cubo.rotation.w);
            /*Quaternion rotationActual = cubo.rotation;
            Quaternion rotationSumar = Quaternion.Euler(0f, 20f, 0f);
            Quaternion roationfinal = rotationActual * rotationSumar;
            cubo.rotation = roationfinal;*/
        pasos = 3;
        transicionLetras.SetActive(true);
        StartCoroutine(transiciondos());
        
        /*if (Input.GetKey(KeyCode.R))
        {
            // Obtener la rotación actual del objeto
            float rotacionZ = cubo.rotation.eulerAngles.z + velocidadRotacion * Time.deltaTime;

            // Calcular la rotación gradual hacia la nueva posición
            Quaternion rotacionDeseada = Quaternion.Euler(0, 0, rotacionZ);
            cubo.rotation = Quaternion.RotateTowards(cubo.rotation, rotacionDeseada, velocidadRotacion * Time.deltaTime);
        }*/

    }
    IEnumerator transicion()
    {
        yield return new WaitForSeconds(2);
        texto2.SetActive(false);
        imagenVRHaptico.SetActive(false);
        texto3.SetActive(true);

        //texto2.SetActive(true);
        //imagenVRHaptico.SetActive(true);

        //texto3.SetActive(true);

        /*imagenop1.SetActive(false);
        imagenop2.SetActive(false);
        imagenop3.SetActive(false);
        eleccion.SetActive(false);
        titulo1.SetActive(false);
        titulo2.SetActive(false);
        titulo3.SetActive(false);
        //texto4.SetActive(true);*/
        //imagenVRHaptico.SetActive(true);
        StartCoroutine(fintransicion());
        pasos = 1;
    }
    IEnumerator fintransicion()
    {
        yield return new WaitForSeconds(2);
        transicionLetras.SetActive(false);
    }
    IEnumerator transiciondos()
    {
        yield return new WaitForSeconds(2);
        instruction2.SetActive(false);
        //texto2.SetActive(true);
        //imagenVRHaptico.SetActive(true);
        //texto3.SetActive(true);
        /*imagenop1.SetActive(true);
        imagenop2.SetActive(true);
        imagenop3.SetActive(true);
        eleccion.SetActive(true);
        titulo1.SetActive(true);
        titulo2.SetActive(true);
        titulo3.SetActive(true);*/
        pasos = 2;
        StartCoroutine (fintransicion());
    }

    IEnumerator transiciontres()
    {
        yield return new WaitForSeconds(2);
        texto2.SetActive (false);
        imagenVRHaptico.SetActive(false);
        texto3.SetActive(true);
        pasos = 3;
        StartCoroutine(fintransicion());
    }
    public void comenzar()
    {
        ScenesInformation.instancia.guardarInfo();
        SceneManager.LoadScene(1);
        centroRoomObject.SetActive(false);
        
    }

    public void siguienteUno()
    {
        if (pasos == 0)
        {
            transicionLetras.SetActive(true);
            StartCoroutine(transicion());
        }
        if (pasos == 1)
        {
            //transicionLetras.SetActive(true);
            reposicionarHaptico();
            StartCoroutine(finSetUp());


        }
        if (pasos == 2)
        {
            transicionLetras.SetActive(true);
            StartCoroutine(transiciontres());
        }
        if (pasos == 3)
        {
            float v = mando.position.x - (float)0.3;
            mireaqui.position = new Vector3(v, mando.position.y, mando.position.z);
            StartCoroutine(cambiodePaso());
            //pasos = 3;

            //transicionLetras.SetActive(true);
            //reposicionarHaptico();
            //StartCoroutine(finSetUp());
        }
        if (pasos == 4)
        {
            reposicionarHaptico();
            StartCoroutine(finSetUp());

        }
    }

    IEnumerator finSetUp()
    {
        yield return new WaitForSeconds(1);
        ScenesInformation.instancia.guardarInfo();
        ScenesInformation.instancia.comenzar();
        
    }
    IEnumerator cambiodePaso()
    {
        yield return new WaitForSeconds(1);
        pasos = 4;
    }
    IEnumerator centrarRoom()
    {
        yield return new WaitForSeconds(1);
        centroRoom.position= centroGafas.position;
    }

    public void settingsMenuOpener()
    {
      
            menuSettings.SetActive(true);
        
        
    }
    public void sliderCanged()
    {
        rotationOffset = sliderOculusRotation.value;
        numeroEscrito.text = sliderOculusRotation.value.ToString();
    }

    public void escritoMano()
    {
        rotationOffset = float.Parse(numeroEscrito.text, CultureInfo.InvariantCulture.NumberFormat);
        sliderOculusRotation.value= float.Parse(numeroEscrito.text, CultureInfo.InvariantCulture.NumberFormat);
    }

    public void closeMenuSettings()
    {
        menuSettings.SetActive(false);

    }

    public void closeApp()
    {
        Application.Quit();
    }

    /*public void skipSetUp()
    {

    }*/
}
