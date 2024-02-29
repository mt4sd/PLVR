using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorRectaDos : MonoBehaviour
{
    public Transform HapticCollider;

    public int desviacionesVerticales;
    public int desviacionesHorizontales;
    public float posicionFinalX;
    public float posicionFinalY;
    public float posicionInicialX;
    public float posicionInicialY;
    public float distanciaX;
    public float distanciaInicialX;
    public float distanciaY;
    public float distanciaInicialY;

    public GameObject pantallazoRojo;
    public GameObject pantallaResultados;
    public GameObject bolaObjetivo;
    public GameObject mensajeRetroceso;
    public GameObject marcaRoja;
    public HapticPlugin hapticplugin;
    public Vector3 angulosGimbal;
    public float tiempo;
    public float tiempofinal;
    public int waiting;
    public int contadorAngulos;

    public ScenesInformation scenesInformation;

    //CREO QUE EN LAS POSICIONES FINALES LOS VALORES DE X E Y ESTÁN CAMBIADOS


    public int contadorFinal;
    public int contadorInicial;
    public int retroceso;
    public int intentos;
    public int SePaso;
    public int errorSalida;
    public float anguloEntradaX;
    public float anguloEntradaY;

    public float desviacionesX;
    public float desviacionesY;
    public float desviacionesInicialX;
    public float desviacionesInicialY;
    public float desviacionesXTotal;
    public float desviacionesYTotal;
    public float posicionInicialX2;
    public float posicionInicialY2;
    public Color red;
    public Material matbolas;
    public GameObject bolita1;
    public GameObject bolita2;
    public GameObject bolita3;
    public GameObject bolita4;
    public GameObject bolita5;
    public GameObject bolita6;
    public GameObject bolita7;
    public GameObject bolita8;
    public GameObject bolita9;
    public GameObject bolita10;
    public GameObject bolita11;
    public GameObject bolita12;

    public float posZmarca;
    public float posYmarca;
    public Transform marcaRetroceso;

    public int startReady;
    public Pausa pause;

    public MeshRenderer meshHD1;
    public MeshRenderer meshHD2;
    public MeshRenderer meshHD3;
    public MeshRenderer meshHD4;
    public MeshRenderer meshHD5;
    public MeshRenderer meshHD6;
    public MeshRenderer meshHD7;
    public MeshRenderer meshHD8;
    public MeshRenderer meshHD9;

    public GameObject baseReposo;
    public GameObject visualMesh;
    // Start is called before the first frame update
    void Start()
    {
        desviacionesVerticales = 0;
        desviacionesHorizontales = 0;
        contadorFinal = 0;
        contadorInicial = 0;
        tiempo = 0;
        retroceso = 0;
        intentos = 0;
        errorSalida = 0;
        waiting = 2;
        contadorAngulos = 0;
        red = Color.red;
        startReady = 0;
    }

    // Update is called once per frame
    void Update()    {
        //posZmarca = marcaRetroceso.localPosition.z;
        //posYmarca = marcaRetroceso.localPosition.y;
        tiempo += Time.deltaTime;
        if (pause.readyExercise3 == true)
        {
            readyOK();
        }
        if (waiting == 2)
        {
            StartCoroutine("Wait");
        }
        if (waiting == 0) {
            angulosGimbal = hapticplugin.GimbalAngles;
            if ((HapticCollider.localPosition.x < -0.1 || HapticCollider.localPosition.x > 0.15) && HapticCollider.localPosition.z <= 1.88 && retroceso==0&&startReady==1)//son los límites entre bolas hay que comprobar luego cuando se pongan los gizmos del háptico HAY QUE AÑADIR CONDICIÓN DE QUE EL LAPIZ ESTÉ POR DELANTE DE LA LINEA AMARILLA EN Z
        {
            bolaObjetivo.SetActive(false);//se deja de ver el objetivo como que no se puede llegar
            desviacionesHorizontales++;//de esta manera contamos las veces que se sale lateralmente
                                       //activar sonido de fallo y flash rojo con contador 
                /*bolita1.GetComponent<Renderer>().material.color = red;
                bolita2.GetComponent<Renderer>().material.color = red;
                bolita3.GetComponent<Renderer>().material.color = red;
                bolita4.GetComponent<Renderer>().material.color = red;
                bolita5.GetComponent<Renderer>().material.color = red;
                bolita6.GetComponent<Renderer>().material.color = red;
                bolita7.GetComponent<Renderer>().material.color = red;
                bolita8.GetComponent<Renderer>().material.color = red;
                bolita9.GetComponent<Renderer>().material.color = red;
                bolita10.GetComponent<Renderer>().material.color = red;
                bolita11.GetComponent<Renderer>().material.color = red;
                bolita12.GetComponent<Renderer>().material.color = red;*/
                //pantallazoRojo.SetActive(true);//activamos pantallazo rojo
                StartCoroutine("Wait");//esperamos un segundo y quitamos el pantallazo rojo
                                       //pantallazoRojo.SetActive(false);//quitamos pantallazo rojo\
                Debug.Log("Antes");
            marcaRoja.SetActive(true);//aparece la marca hasta la que hay que retroceder
                Debug.Log("Despues");
            //mensajeRetroceso.SetActive(true);//que aparezca canva que te mande a volver para atrás
            StartCoroutine("Wait2");//esperamos dos segundos para que le de timepo a quitar el boli de los límites
            retroceso = 1;
            SePaso = 1;
                waiting = 1;
                //waiting = 1;
        }
        /*if ((HapticCollider.position.y < 0.12 || HapticCollider.position.y > 0.162) && HapticCollider.localPosition.z <= 1.88 && retroceso==0)
        {
            bolaObjetivo.SetActive(false);//se deja de ver el objetivo como que no se puede llegar
            desviacionesHorizontales++;//de esta manera contamos las veces que se sale lateralmente
                                       //activar sonido de fallo y flash rojo con contador 
                bolita1.GetComponent<Renderer>().material.color = red;
                bolita2.GetComponent<Renderer>().material.color = red;
                bolita3.GetComponent<Renderer>().material.color = red;
                bolita4.GetComponent<Renderer>().material.color = red;
                bolita5.GetComponent<Renderer>().material.color = red;
                bolita6.GetComponent<Renderer>().material.color = red;
                bolita7.GetComponent<Renderer>().material.color = red;
                bolita8.GetComponent<Renderer>().material.color = red;
                bolita9.GetComponent<Renderer>().material.color = red;
                bolita10.GetComponent<Renderer>().material.color = red;
                bolita11.GetComponent<Renderer>().material.color = red;
                bolita12.GetComponent<Renderer>().material.color = red;
                //pantallazoRojo.SetActive(true);//activamos pantallazo rojo
                StartCoroutine("Wait");//esperamos un segundo y quitamos el pantallazo rojo
            //pantallazoRojo.SetActive(false);//quitamos pantallazo rojo
            marcaRoja.SetActive(true);//aparece la marca hasta la que hay que retroceder
            //mensajeRetroceso.SetActive(true);//que aparezca canva que te mande a volver para atrás
            StartCoroutine("Wait2");//esperamos dos segundos para que le de timepo a quitar el boli de los límites
            retroceso = 1;
            SePaso = 1;
                waiting = 1;
        }*/
        if (HapticCollider.localPosition.z <= 1.88 && HapticCollider.localPosition.z >= 1.64 && retroceso==1)//comprueba si está en retroceso y hasta dónde retrocede
        {
            marcaRoja.SetActive(false);
            bolaObjetivo.SetActive(true);
            retroceso = 0;
            intentos++;
                contadorAngulos = 0;
                //StartCoroutine("Wait");//esperamos un segundo y quitamos el pantallazo rojo

                //waiting = 0;
            }

            if (HapticCollider.localPosition.z>=1.88 && SePaso == 1)//si retrocede más allá de la línea roja
        {
            //pantallazoRojo.SetActive(true);//
            StartCoroutine("Wait");
            SePaso = 0;
            contadorInicial = 0;
            errorSalida++;
        }
        //if (HapticCollider.position.z <= -0.915 && contadorInicial == 0)//creo que esto es para que no cuente si empieza atrás
        //{
        // contadorInicial = 1;
        //}
        if (HapticCollider.localPosition.z <= 1.88 && contadorInicial ==0&& startReady==1)
        {
                

            posicionInicialX = HapticCollider.localPosition.x;
            posicionInicialX2 = posicionInicialX;
            posicionInicialY = HapticCollider.localPosition.y;
            intentos++;
            contadorInicial++;
            distanciaInicialX = (float)(posicionInicialX - 0.95);//poner en valor absoluto
            //asignar distanciaX como texto a un campo del canva
            //activar canva con los resultados
            distanciaInicialY = (float)(-0.007 - posicionInicialY);
            //hacer lo mismo para y
            //intentos = 1;
            if (posicionInicialX <= 0.955 && posicionInicialX >= 0.954)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionInicialX <= 0.96 && posicionInicialX >= 0.955) || (posicionInicialX <= 0.945 && posicionInicialX >= 0.94))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionInicialX < 0.94 || posicionInicialX > 0.94)
            {
                //dar la peor puntuación
            }
            if (posicionInicialY <= -0.012 && posicionInicialY >= -0.002)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionInicialY <= -0.012 && posicionInicialY >= -0.017) || (posicionInicialY <= 0.003 && posicionInicialY >= -0.002))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionInicialY < -0.017 || posicionInicialY > 0.003)
            {
                //dar la peor puntuación
            }
            contadorInicial = 1;
        }
            if (HapticCollider.localPosition.z <= 1.68 && contadorAngulos==0&&startReady==1)
            {
                
                anguloEntradaX = angulosGimbal.x;
                anguloEntradaY = angulosGimbal.y;
                contadorAngulos++;
            }
            if(HapticCollider.localPosition.z<=1.68 && contadorAngulos >= 1&&startReady==1)
            {
                if (Mathf.Abs(anguloEntradaX - angulosGimbal.x) >= 30)
                {
                    bolaObjetivo.SetActive(false);
                    marcaRoja.SetActive(true);
                    waiting = 1;
                    SePaso = 1;
                    retroceso = 1; 
                    /*bolita1.GetComponent<Renderer>().material.color = red;
                    bolita2.GetComponent<Renderer>().material.color = red;
                    bolita3.GetComponent<Renderer>().material.color = red;
                    bolita4.GetComponent<Renderer>().material.color = red;
                    bolita5.GetComponent<Renderer>().material.color = red;
                    bolita6.GetComponent<Renderer>().material.color = red;
                    bolita7.GetComponent<Renderer>().material.color = red;
                    bolita8.GetComponent<Renderer>().material.color = red;
                    bolita9.GetComponent<Renderer>().material.color = red;
                    bolita10.GetComponent<Renderer>().material.color = red;
                    bolita11.GetComponent<Renderer>().material.color = red;
                    bolita12.GetComponent<Renderer>().material.color = red;*/

                    StartCoroutine("Wait");
                }
                if(Mathf.Abs(anguloEntradaY - angulosGimbal.y) >= 30)
                {
                    bolaObjetivo.SetActive(false);
                    marcaRoja.SetActive(true);
                    waiting = 1;
                    SePaso = 1;
                    retroceso = 1;
                    StartCoroutine("Wait");
                    /*bolita1.GetComponent<Renderer>().material.color = red;
                    bolita2.GetComponent<Renderer>().material.color = red;
                    bolita3.GetComponent<Renderer>().material.color = red;
                    bolita4.GetComponent<Renderer>().material.color = red;
                    bolita5.GetComponent<Renderer>().material.color = red;
                    bolita6.GetComponent<Renderer>().material.color = red;
                    bolita7.GetComponent<Renderer>().material.color = red;
                    bolita8.GetComponent<Renderer>().material.color = red;
                    bolita9.GetComponent<Renderer>().material.color = red;
                    bolita10.GetComponent<Renderer>().material.color = red;
                    bolita11.GetComponent<Renderer>().material.color = red;
                    bolita12.GetComponent<Renderer>().material.color = red;*/
                }

            }
            if (contadorInicial >= 1)
        {
            desviacionesX = HapticCollider.localPosition.x - posicionInicialX2;
            desviacionesXTotal = desviacionesXTotal + (Mathf.Abs(desviacionesX));
            posicionInicialX2 = HapticCollider.localPosition.x;

            desviacionesY = HapticCollider.localPosition.y - posicionInicialY2;
            desviacionesYTotal = desviacionesYTotal + (Mathf.Abs(desviacionesY));
            posicionInicialY2 = HapticCollider.localPosition.y;
        }
        if (HapticCollider.localPosition.z <= 0.53 && contadorFinal == 0)
        {//ya llegó al punto objetivo
            posicionFinalX = HapticCollider.localPosition.x;
            posicionFinalY = HapticCollider.localPosition.y;
            contadorFinal++;
            tiempofinal = tiempo;
            distanciaX = (float)(posicionFinalX - 0.95);//poner en valor absoluto
            //asignar distanciaX como texto a un campo del canva
            //activar canva con los resultados
            distanciaY = (float)(-0.007 - posicionFinalY);
                //hacer lo mismo para y
                //pantallaResultados.SetActive(true);//mostrar canva de resultados
                ScenesInformation.instancia.esferaTransitions.SetActive(true);
                StartCoroutine(ShowResultados());
            if (posicionFinalX <= 0.955 && posicionFinalX >= 0.954)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionFinalX <= 0.96 && posicionFinalX >= 0.955) || (posicionFinalX <= 0.945 && posicionFinalX >= 0.94))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionFinalX < 0.94 || posicionFinalX > 0.94)
            {
                //dar la peor puntuación
            }
            if (posicionFinalY <= -0.012 && posicionFinalY >= -0.002)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionFinalY <= -0.012 && posicionFinalY >= -0.017) || (posicionFinalY <= 0.003 && posicionFinalY >= -0.002))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionFinalY < -0.017 || posicionFinalY > 0.003)
            {
                //dar la peor puntuación
            }
        }
        }


    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        /*pantallazoRojo.SetActive(false);//quitamos pantallazo rojo
        bolita1.GetComponent<Renderer>().material = matbolas;
        bolita2.GetComponent<Renderer>().material = matbolas;
        bolita3.GetComponent<Renderer>().material = matbolas;
        bolita4.GetComponent<Renderer>().material = matbolas;
        bolita5.GetComponent<Renderer>().material = matbolas;
        bolita6.GetComponent<Renderer>().material = matbolas;
        bolita7.GetComponent<Renderer>().material = matbolas;
        bolita8.GetComponent<Renderer>().material = matbolas;
        bolita9.GetComponent<Renderer>().material = matbolas;
        bolita10.GetComponent<Renderer>().material = matbolas;
        bolita11.GetComponent<Renderer>().material = matbolas;
        bolita12.GetComponent<Renderer>().material = matbolas;*/
        waiting = 0;
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
        mensajeRetroceso.SetActive(false);
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene("MENU");
    }
    public void readyOK()
    {
        startReady = 1;
    }
    IEnumerator ShowResultados()
    {
        yield return new WaitForSeconds(2);

        pantallaResultados.SetActive(true);
        meshHD1.enabled = true;
        meshHD2.enabled = true;
        meshHD3.enabled = true;
        meshHD4.enabled = true;
        meshHD5.enabled = true;
        meshHD6.enabled = true;
        meshHD7.enabled = true;
        meshHD8.enabled = true;
        meshHD9.enabled = true;
        baseReposo.SetActive(true);

        visualMesh.SetActive(false);
        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);

    }
}
