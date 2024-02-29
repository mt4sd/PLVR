using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorRecta : MonoBehaviour
{

    public ScenesInformation scenesInformation;

    // declaro las componecentes necesarias del haptico
    public Transform HapticCollider;
    public Transform TipReference;
    //declaro las variables donde almacenar datos
    public int desviacionesVerticales;
    public int desviacionesHorizontales;
    public float posicionFinalX;
    public float posicionFinalY;
    public float posicionInicialX;
    public float posicionInicialX2;

    public float posicionInicialY;
    public float posicionInicialY2;
    public float distanciaX;
    public float distanciaInicialX;
    public float distanciaY;
    public float distanciaInicialY;

    public float desviacionesX;
    public float desviacionesXTotal;
    public float desviacionesY;
    public float desviacionesYTotal;
    


    public GameObject pantallazoRojo;
    public GameObject pantallaResultados;
    public float tiempo;
    public float tiempofinal;
    public int waiting;
    public Transform dianaReferencia;

    //CREO QUE EN LAS POSICIONES FINALES LOS VALORES DE X E Y ESTÁN CAMBIADOS


    public int contadorFinal;
    public int contadorInicial;
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

    public Slider sliderDHInicial;//es el del timepo total
    public Slider sliderDVInicial;
    public Slider sliderDHFinal;
    public Slider sliderDVFinal;
    public Slider sliderDH;
    public Slider sliderDV;
    public Slider sliderDistanciaH;
    public Slider sliderDistanciaV;
    public Slider sliderTiempo;

    public GameObject esferaResultados;
    public int startReady;

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

    public bool isWaiting;
    // Start is called before the first frame update
    void Start()
    {
        desviacionesVerticales = 0;
        desviacionesHorizontales = 0;
        contadorFinal = 0;
        contadorInicial = 0;
        tiempo = 0;
        waiting = 2;
        red = Color.red;
        startReady = 0;
        isWaiting = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (isWaiting == true)
        {
            StartCoroutine(NotWaiting());
        }
        else
        {
            startReady = 1;
        }
        
        if (waiting == 2)
        {
            StartCoroutine("Wait");
        }
        tiempo += Time.deltaTime;
        if (waiting == 0) {

            if ((HapticCollider.localPosition.x < -0.1 || HapticCollider.localPosition.x > 0.15) && HapticCollider.localPosition.z <= 1.88 && startReady ==1)//son los límites entre bolas hay que comprobar luego cuando se pongan los gizmos del háptico HAY QUE AÑADIR CONDICIÓN DE QUE EL LAPIZ ESTÉ POR DELANTE DE LA LINEA AMARILLA EN Z
        {
            desviacionesHorizontales++;//de esta manera contamos las veces que se sale lateralmente
                
                 // bolita1.GetComponent<Renderer>().material.color = red;
                //bolita2.GetComponent<Renderer>().material.color = red;
                //bolita3.GetComponent<Renderer>().material.color = red;
                //bolita4.GetComponent<Renderer>().material.color = red;
                //bolita5.GetComponent<Renderer>().material.color = red;
                //bolita6.GetComponent<Renderer>().material.color = red;
                //bolita7.GetComponent<Renderer>().material.color = red;
                //bolita8.GetComponent<Renderer>().material.color = red;
                //bolita9.GetComponent<Renderer>().material.color = red;
                //bolita10.GetComponent<Renderer>().material.color = red;
                //bolita11.GetComponent<Renderer>().material.color = red;
                //bolita12.GetComponent<Renderer>().material.color = red;
                 if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y>0.15&& HapticCollider.localPosition.z<1.88&& HapticCollider.localPosition.z>1.48)
                 {
                     bolita1.GetComponent<Renderer>().material.color = red;//ARRIBA IZQUIERDA ALANTE
                 }
                 if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y > 0.15 && HapticCollider.localPosition.z <1.48  && HapticCollider.localPosition.z > 1.14)
                 {
                     bolita2.GetComponent<Renderer>().material.color = red;//ARRIBA IZQUIERDA MEDIA
                 }
                 if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y > 0.15 && HapticCollider.localPosition.z < 1.14)
                 {
                     bolita3.GetComponent<Renderer>().material.color = red;//ARRIBA IZQUIERDA ATRAS
                 }
                 if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y > 0.15 && HapticCollider.localPosition.z < 1.88 && HapticCollider.localPosition.z > 1.48)
                 {
                     bolita4.GetComponent<Renderer>().material.color = red;//ARRIBA DERECHA ALANTE
                 }
                 if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y > 0.15 && HapticCollider.localPosition.z < 1.48 && HapticCollider.localPosition.z > 1.14)
                 {
                     bolita5.GetComponent<Renderer>().material.color = red;//ARRIBA DERECHA MEDIO
                 }
                 if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y > 0.15 && HapticCollider.localPosition.z < 1.14)
                 {
                     bolita6.GetComponent<Renderer>().material.color = red;//ARRIBA DERECHA ATRÁS
                 }
                if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.88 && HapticCollider.localPosition.z > 1.48)
                {
                    bolita7.GetComponent<Renderer>().material.color = red;//ABAJO IZQUIERDA ALANTE
                }
                if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.48 && HapticCollider.localPosition.z > 1.14)
                {
                    bolita8.GetComponent<Renderer>().material.color = red;//ABAJO IZQUIERDA MEDIA
                }
                if (HapticCollider.localPosition.x > 0.15 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.14)
                {
                    bolita9.GetComponent<Renderer>().material.color = red;//ABAJO IZQUIERDA ATRAS
                }
                if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.88 && HapticCollider.localPosition.z > 1.48)
                {
                    bolita10.GetComponent<Renderer>().material.color = red;//ABAJO DERECHA ALANTE
                }
                if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.48 && HapticCollider.localPosition.z > 1.14)
                {
                    bolita11.GetComponent<Renderer>().material.color = red;//ABAJO DERECHA MEDIO
                }
                if (HapticCollider.localPosition.x < -0.1 && HapticCollider.localPosition.y < 0.15 && HapticCollider.localPosition.z < 1.14)
                {
                    bolita12.GetComponent<Renderer>().material.color = red;//ARRIBA DERECHA ATRÁS
                }


                //activar sonido de fallo y flash rojo con contador 
                //pantallazoRojo.SetActive(true);//activamos pantallazo rojo
                StartCoroutine("Wait");//esperamos un segundo y quitamos el pantallazo rojo
            //pantallazoRojo.SetActive(false);//quitamos pantallazo rojo
            StartCoroutine("Wait2");//esperamos dos segundos para que le de timepo a quitar el boli de los límites*
                waiting = 1;

        }
        if ((HapticCollider.position.y < 0.12 || HapticCollider.position.y > 0.162)&& HapticCollider.position.z<=0.01)
        {
            desviacionesVerticales++;//de esta amnera contamos las veces que se sale verticalmente
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
            //pantallazoRojo.SetActive(false);//quitamos pantallazo rojo
            StartCoroutine("Wait2");//esperamos dos segundos para que le de timepo a quitar el boli de los límites
                waiting = 1;

        }
        if (HapticCollider.position.z <= 0.01 && contadorInicial == 0)
        {
            contadorInicial = 1;
        }
        if (HapticCollider.position.z <= 0.01 && contadorInicial == 1)
        {
            posicionInicialX = HapticCollider.position.x;
                posicionInicialX2 = posicionInicialX;
            posicionInicialY = HapticCollider.position.y;
                posicionInicialY2 = posicionInicialY;
            contadorInicial++;
            distanciaInicialX = (float) (posicionInicialX - 0.007);//poner en valor absoluto
            //asignar distanciaX como texto a un campo del canva
            //activar canva con los resultados
            distanciaInicialY = (float) (0.95 - posicionInicialY);
            //hacer lo mismo para y
            if (posicionInicialY <= 0.955 && posicionInicialY >= 0.954)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionInicialY <= 0.96 && posicionInicialY >= 0.955) || (posicionInicialY <= 0.945 && posicionInicialY >= 0.94))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionInicialY < 0.94 || posicionInicialY > 0.94)
            {
                //dar la peor puntuación
            }
            if (posicionInicialX <= -0.012 && posicionInicialX >= -0.002)
            {
                //Dar la mejor puntuación (verde);
            }
            if ((posicionInicialX <= -0.012 && posicionInicialX >= -0.017) || (posicionInicialX <= 0.003 && posicionInicialX >= -0.002))
            {
                //dar la segunda puntuacion (amarilla)
            }
            if (posicionInicialX < -0.017 || posicionInicialX > 0.003)
            {
                //dar la peor puntuación
            }

        }
        if (contadorInicial > 1)
            {
                desviacionesX = HapticCollider.position.x - posicionInicialX2;
                desviacionesXTotal = desviacionesXTotal + (Mathf.Abs(desviacionesX));
                posicionInicialX2 = HapticCollider.position.x;

                desviacionesY = HapticCollider.position.y - posicionInicialY2;
                desviacionesYTotal = desviacionesYTotal + (Mathf.Abs(desviacionesY));
                posicionInicialY2 = HapticCollider.position.y;
            }
        if (HapticCollider.localPosition.z <= 0.53 && contadorFinal==0){//ya llegó al punto objetivo
            posicionFinalX = HapticCollider.position.x;
            posicionFinalY = HapticCollider.position.y;
            contadorFinal++;
            tiempofinal = tiempo;
            distanciaX =(float) (posicionFinalX - 0.95);//poner en valor absoluto
            //asignar distanciaX como texto a un campo del canva
            //activar canva con los resultados
            distanciaY = (float)(-0.007 - posicionFinalY);
                sliderDH.value = desviacionesHorizontales;
                sliderDV.value = desviacionesVerticales;
                sliderTiempo.value = tiempofinal;
                sliderDistanciaH.value = desviacionesXTotal;
                sliderDistanciaV.value = desviacionesYTotal;
                sliderDHInicial.value = Mathf.Abs((dianaReferencia.position.x) - posicionInicialX);
                sliderDVInicial.value=Mathf.Abs((dianaReferencia.position.y) - posicionInicialY);
                sliderDHFinal.value = Mathf.Abs((dianaReferencia.position.x) - posicionFinalX);
                sliderDVFinal.value=Mathf.Abs((dianaReferencia.position.y)- posicionFinalY);
            //hacer lo mismo para y
            //pantallaResultados.SetActive(true);//mostrar canva de resultados
            /*if(posicionFinalX<=0.955 && posicionFinalX >= 0.954)
             
            {
                //Dar la mejor puntuación (verde);
            }
            if((posicionFinalX<=0.96 && posicionFinalX>=0.955)||(posicionFinalX<=0.945 && posicionFinalX >= 0.94))
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
            }*/

            //PUNTUACIONES LIMITACIONES
            
                waiting = 1;//llegó al final se acabó y no vuelve a hacer nada en el update
                //esferaResultados.SetActive(true);
                ScenesInformation.instancia.esferaTransitions.SetActive(true);
                StartCoroutine(ShowResultados());
                //pantallaResultados.SetActive(true);
        }
        }

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        pantallazoRojo.SetActive(false);//quitamos pantallazo rojo
        waiting = 0;
        /*bolita1.GetComponent<Renderer>().material = matbolas;
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

    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene("MENU");
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
    IEnumerator NotWaiting()
    {
        yield return new WaitForSeconds(2);
        if (HapticCollider.localPosition.z >= 1.9)
        {
            isWaiting = false;
        }
    }
}
