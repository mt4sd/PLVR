using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
using UnityEngine.Animations;
//FALTA VALORAR SI ESTAN DENTRO DE LOS LÍMITES Y DAR UNA PUNTUACIÓN A CADA VARIABLE

public class BS1Controller : MonoBehaviour
{ //declaro los 18 números aleatorios que van a determinar la posición de las bolas

    #region VARIABLES

    public float limXright;
    public float limXleft;
    public float limYup;
    public float limYdown;
    public float limZ1;
    public float limZ2;
    public float limZ3;


    public float num11;
    public float num12;
    public float num13;

    public float num21;
    public float num22;
    public float num23;

    public float num31;
    public float num32;
    public float num33;

    public float num41;
    public float num42;
    public float num43;

    public float num51;
    public float num52;
    public float num53;

    public float num61;
    public float num62;
    public float num63;

    public bool readyForResults;
    public GameObject visualMesh;
    public GameObject visualMesh2;
    public GameObject baseReposo;

    public ScenesInformation scenesInformation;


    // declaro la posicion de cada diana objetivo
    public Transform diana1;
    public Transform diana2;
    public Transform diana3;
    public Transform diana4;
    public Transform diana5;
    public Transform diana6;
    public GameObject diana1objeto;
    public GameObject diana2objeto;
    public GameObject diana3objeto;
    public GameObject diana4objeto;
    public GameObject diana5objeto;
    public GameObject diana6objeto;

    public Transform diana1B;
    public Transform diana2B;
    public Transform diana3B;
    public Transform diana4B;
    public Transform diana5B;
    public Transform diana6B;
    public GameObject diana1objetoB;
    public GameObject diana2objetoB;
    public GameObject diana3objetoB;
    public GameObject diana4objetoB;
    public GameObject diana5objetoB;
    public GameObject diana6objetoB;

    //declaro los objetos necesarios del haptico y las variables que quiero de el
    public GameObject HapticActor;
    public Transform collider;
    public Transform referenciaTip;
    public Vector3 fuerzas;
    public Vector3 angulos;
    public int contador;
    public HapticPlugin hapticplugin;

    public Pausa pausaScript;



    // declaro la variable donde alamacenare cada angulo de insercion, la posicion con respecto al centro de la diana y el tiempo
    public float angX1;
    public float angY1;
    public float angZ1;
    public float posX1;
    public float posY1;
    public float tiempobola1;


    public float angX2;
    public float angY2;
    public float angZ2;
    public float posX2;
    public float posY2;
    public float tiempobola2;

    public float angX3;
    public float angY3;
    public float angZ3;
    public float posX3;
    public float posY3;
    public float tiempobola3;


    public float angX4;
    public float angY4;
    public float angZ4;
    public float posX4;
    public float posY4;
    public float tiempobola4;


    public float angX5;
    public float angY5;
    public float angZ5;
    public float posX5;
    public float posY5;
    public float tiempobola5;


    public float angX6;
    public float angY6;
    public float angZ6;
    public float posX6;
    public float posY6;
    public float tiempobola6;


    public int compilo;
    public int checkInit;
    public GameObject pantallaVerde;
    public GameObject pantallaResultados;
    public float tiempo;//para el contador de tiempo
    public float tiempoEspera;

    public float DifX1;
    public float DifX2;
    public float DifX3;
    public float DifX4;
    public float DifX5;
    public float DifX6;
    public float DifY1;
    public float DifY2;
    public float DifY3;
    public float DifY4;
    public float DifY5;
    public float DifY6;

    //public Slider sliderTiempo;   // Slider en el canvas
    /*public float valorMinimoTiempo = 0; // Valor mínimo del slider
    public float valorMaximoTiempo = 150; // Valor máximo del slider
    public float valorVariableTiempo; // Valor de la variable a vincular con el slider
    //public Image fill; // Fill del Slider para cambiar el color
    public Color verde = Color.green; // Color para valores mayores a 70
    public Color amarillo = Color.yellow; // Color para valores entre 40 y 70
    public Color rojo = Color.red; // Color para valores menores a 40*/
    public float tiempoTotal;
    public Slider sliderTiempo;
    public Slider sliderTiempo1;
    public Slider sliderTiempo2;
    public Slider sliderTiempo3;
    public Slider sliderTiempo4;
    public Slider sliderTiempo5;
    public Slider sliderTiempo6;
    public Slider sliderDis1;
    public Slider sliderDis2;
    public Slider sliderDis3;
    public Slider sliderDis4;
    public Slider sliderDis5;
    public Slider sliderDis6;
    public Slider sliderDifY1;
    public Slider sliderDifY2;
    public Slider sliderDifY3;
    public Slider sliderDifY4;
    public Slider sliderDifY5;
    public Slider sliderDifY6;
    public GameObject resultados;

    public float tiempoMedio;
    public float distanciaMediaX;
    public float distanciaMediaY;
    public Slider sliderTiempoMedio;
    public Slider sliderDistanciaMediaX;
    public Slider sliderDistanciaMediaY;

    public Image negro;

    public GameObject posicionReposo;
    //public Animator animResultados;
    public bool condicion;
    public GameObject esferaResultados;
    // Start is called before the first frame update
    public float limiteDiana;

    public MeshRenderer meshHD1;
    public MeshRenderer meshHD2;
    public MeshRenderer meshHD3;
    public MeshRenderer meshHD4;
    public MeshRenderer meshHD5;
    public MeshRenderer meshHD6;
    public MeshRenderer meshHD7;
    public MeshRenderer meshHD8;
    public MeshRenderer meshHD9;
    public MeshRenderer meshaguja;
    public MeshRenderer meshmano1;
    public MeshRenderer meshmano2;
    public MeshRenderer meshmano3;


    public int level;
    public float patient;

    public float distanciaD1;
    public float distanciaD2;
    public float distanciaD3;
    public float distanciaD4;
    public float distanciaD5;
    public float distanciaD6;

    public float resistanceLimit;
    public float foceValue;

    public GameObject saveButton;
    #endregion
    void Start()
    {
        StartCoroutine(quitaresfera());
        readyForResults = false;
        hapticplugin = FindObjectOfType<HapticPlugin>();//para encontrar el script hapticplugin dentro del objeto del hptio
        contador = 0;
        tiempo = 0;
        checkInit = 0;
        level = 1;
        patient = ScenesInformation.instancia.opPatientPosition;

        // Establece el valor mínimo y máximo del slider
        //sliderTiempo.minValue = valorMinimoTiempo;
        //sliderTiempo.maxValue = valorMaximoTiempo;

        System.Random aleatorio = new System.Random();
        //en un futuro serán de 12 números o de 18 en función si también hacemos eje z

        /*num11 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num12 = aleatorio.Next(110, 200);//limites del eje y
        num13 = aleatorio.Next(0,5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita1 = new Vector3((float)(num11 / 1000), (float)(num12 / 1000), (float)0.0005);
        diana1.position = bolita1;

        /*diana1.position.x = -num11 / 100;
        diana1.position.y = num12 / 100;
        diana1.position.z = num13 / 100;*/

        /*num21 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num22 = aleatorio.Next(110, 200);//limites del eje y
        num23 = aleatorio.Next(0, 5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita2 = new Vector3((float)(-(num21) / 1000), (float)(num22 / 1000), (float)0.0005);
        diana2.position = bolita2;

        /*diana2.position.x = num21 / 100;
        diana2.position.y = num22 / 100;
        diana2.position.z = num23 / 100;*/

        /*num31 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num32 = aleatorio.Next(110, 200);//limites del eje y
        num33 = aleatorio.Next(0, 5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita3 = new Vector3((float)(num31 / 1000), (float)(num32 / 1000), (float)0.0005);
        diana3.position = bolita3;
        /*diana3.position.x = -num31 / 100;
        diana3.position.y = num32 / 100;
        diana3.position.z = num33 / 100;*/

        /*num41 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num42 = aleatorio.Next(110, 200);//limites del eje y
        num43 = aleatorio.Next(0, 5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita4 = new Vector3((float)(-(num41) / 1000), (float)(num42 / 1000), (float)0.0005);
        diana4.position = bolita4;
        /*diana4.position.x = num41 / 100;
        diana4.position.y = num42 / 100;
        diana4.position.z = num43 / 100;*/

        /*num51 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num52 = aleatorio.Next(110, 200);//limites del eje y
        num53 = aleatorio.Next(0, 5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita5 = new Vector3((float)(num51 / 1000), (float)(num52 / 1000), (float)0.0005);
        diana5.position = bolita5;
        /*diana5.position.x = -num51 / 100;
        diana5.position.y = num52 / 100;
        diana5.position.z = num53 / 100;*/

        /*num61 = aleatorio.Next(15, 55); //luego para hacerlo decimal lo divido entre 100 limites del eje x
        num62 = aleatorio.Next(110, 200);//limites del eje y
        num63 = aleatorio.Next(0, 5);//cuando se vea la jaula del háptico podré determinar el número z
        Vector3 bolita6 = new Vector3((float)(-(num61) / 1000), (float)(num62 / 1000), (float)0.0005);
        diana6.position = bolita6;
        /*diana6.position.x = num61 / 100;                                                                       
        diana6.position.y = num62 / 100;
        diana6.position.z = num63 / 100;*/
        //

        num11 = aleatorio.Next(1, 100);
        num12 = aleatorio.Next(1, 100);
        num21 = aleatorio.Next(1, 100);
        num22 = aleatorio.Next(1, 100);
        num31 = aleatorio.Next(1, 100);
        num32 = aleatorio.Next(1, 100);

        //AÑADIR ESTO PARA DETERMINAR QUE DIANA VA PRIMERO
        if (num11 >= num12)
        {
            if (patient == 0)
            {
                diana1objeto.SetActive(true);

            }
            if(patient == 1)
            {
                diana1objetoB.SetActive(true);
            }
        }
        if (num11 < num12)
        {
            if (patient == 0)
            {
                diana2objeto.SetActive(true);

            }
            if (patient == 1)
            {
                diana2objetoB.SetActive(true);

            }
        }


    }

    private bool isWaiting = false;
    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;//para ir actualizando el timepo
        if (isWaiting) return;
        /*if (tiempo == 1){
            checkInit = 1;
        }*/

        fuerzas = hapticplugin.CurrentForce;//almacenando el valor de las fuerzas para luego detectar cuando sobrepase la de las bolitas
        #region PacienteSentado
        if (patient == 0)
        {
            if (collider.localPosition.y > 0.74) //ESTOS DOS IFs SIRVEN PARA DETERMINAR SI EST'A TOCANDO DIANAS ARRIBA O ABAJO Y CAMBIAR ENTONCES LOS LIMITES
            {
                Debug.Log("esta arriba");

                limXleft = (float)0.093;
                limXright = (float)-0.126;
                limYup = (float)1.097;
                limYdown = (float)0.856;
                limZ1 = (float)0.95;
                limZ2 = (float)0.58;
                limZ3 = (float)0.37;
            }
            if (collider.localPosition.y < 0.74)
            {
                Debug.Log("esta abajo");

                limXleft = (float)0.093;
                limXright = (float)-0.126;
                limYup = (float)0.607;
                limYdown = (float)0.354;
                limZ1 = (float)1.06;
                limZ2 = (float)0.68;
                limZ3 = (float)0.5;
            }
            /*switch (contador)
            {
                case 0:
                    resistanceLimit = limZ1;
                    forceValue = (float)0.3;
                    break;
                case 1:
                    resistanceLimit = limZ1;
                    forceValue = (float)0.3;
                    break;
                case 2:
                    resistanceLimit = limZ2;
                    forceValue = (float)0.7;
                    break;
                case 3:
                    resistanceLimit = limZ2;
                    forceValue = (float)0.7;
                    break;
                case 4:
                    resistanceLimit = limZ3;
                    forceValue = (float)1.1;
                    break;
                case 5:
                    resistanceLimit = limZ3;
                    forceValue = (float)1.1;
                    break;
            }*/
            #region DianaDetector
            if (collider.localPosition.z <= limZ1 && collider.localPosition.y < limYup && collider.localPosition.y > limYdown && collider.localPosition.x < limXleft && collider.localPosition.x > limXright && fuerzas.z != 0.2)
                //HAY QUE SUSTITUIR LOS CEROS POR LOS VALORES LÍMITES DE LAS DIANAS SEGÚN LA VARIABLE LOCAL DE POSICIÓN DENTRO DE LA ESCENA
            {
                #region CONDICIONESPIEL
                if (collider.localPosition.z <= limZ1 && level == 1) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN EN Z LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                        case 0:
                            if (num11 >= num12)
                            {
                                diana1objeto.SetActive(false);
                                diana2objeto.SetActive(true);
                            }
                            if (num11 < num12)
                            {
                                diana2objeto.SetActive(false);
                                diana1objeto.SetActive(true);
                            }
                            //contador++;
                            angX1 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY1 = angulos.y;
                            angZ1 = angulos.z;
                            posX1 = collider.position.x;
                            posY1 = collider.position.y;
                            DifX1 = MathF.Abs(posX1 - (diana1.position.x));
                            DifY1 = MathF.Abs(posY1 - (diana1.position.y));
                            tiempobola1 = tiempo - pausaScript.tiempoRetraso;
                            ischanged = true;
                            break;
                        case 1:
                            diana1objeto.SetActive(false);
                            diana2objeto.SetActive(false);
                            if (num21 >= num22)
                            {
                                diana3objeto.SetActive(true);
                            }
                            if (num21 < num22)
                            {
                                diana4objeto.SetActive(true);
                            }
                            angX2 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY2 = angulos.y;
                            angZ2 = angulos.z;
                            posX2 = collider.position.x;
                            posY2 = collider.position.y;
                            tiempobola2 = tiempo - tiempobola1 - pausaScript.tiempoRetraso;
                            DifX2 = MathF.Abs(posX2 - (diana2.position.x));
                            DifY2 = MathF.Abs(posY2 - (diana2.position.y));
                            ischanged = true;
                            level = 2;
                            break;
                        
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
                #region CONDICIONES LA
                if (collider.localPosition.z <=limZ2 && level == 2) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN EN Z del ligamento amarillo LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                       
                        case 2:
                            if (num21 >= num22)
                            {
                                diana3objeto.SetActive(false);
                                diana4objeto.SetActive(true);
                            }
                            if (num21 < num22)
                            {
                                diana4objeto.SetActive(false);
                                diana3objeto.SetActive(true);
                            }
                            angX3 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY3 = angulos.y;
                            angZ3 = angulos.z;
                            posX3 = collider.position.x;
                            posY3 = collider.position.y;
                            tiempobola3 = tiempo - (tiempobola1 + tiempobola2) - pausaScript.tiempoRetraso;
                            DifX3 = MathF.Abs(posX3 - (diana3.position.x));
                            DifY3 = MathF.Abs(posY3 - (diana3.position.y));
                            ischanged = true;
                            break;
                        case 3:
                            diana4objeto.SetActive(false);
                            diana3objeto.SetActive(false);
                            if (num31 >= num32)
                            {
                                diana5objeto.SetActive(true);
                            }
                            if (num31 < num32)
                            {
                                diana6objeto.SetActive(true);
                            }
                            angX4 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY4 = angulos.y;
                            angZ4 = angulos.z;
                            posX4 = collider.position.x;
                            posY4 = collider.position.y;
                            tiempobola4 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3) - pausaScript.tiempoRetraso;
                            DifX4 = MathF.Abs(posX4 - (diana4.position.x));
                            DifY4 = MathF.Abs(posY4 - (diana4.position.y));
                            level = 3;
                            ischanged = true;

                            break;
                       
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
                #region CONDICIONES DM
                if (collider.localPosition.z <= limZ3 && level == 3) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN del saco dural EN Z LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                        
                        case 4:
                            if (num31 >= num32)
                            {
                                diana5objeto.SetActive(false);
                                diana6objeto.SetActive(true);

                            }
                            if (num31 < num32)
                            {
                                diana6objeto.SetActive(false);
                                diana5objeto.SetActive(true);

                            }

                            angX5 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY5 = angulos.y;
                            angZ5 = angulos.z;
                            posX5 = collider.position.x;
                            posY5 = collider.position.y;
                            tiempobola5 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4) - pausaScript.tiempoRetraso;
                            DifX5 = MathF.Abs(posX5 - (diana5.position.x));
                            DifY5 = MathF.Abs(posY5 - (diana5.position.y));
                            ischanged = true;

                            break;
                        case 5:
                            diana6objeto.SetActive(false);
                            diana5objeto.SetActive(false);
                            angX6 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY6 = angulos.y;
                            angZ6 = angulos.z;
                            posX6 = collider.position.x;
                            posY6 = collider.position.y;
                            tiempobola6 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4 + tiempobola5) - pausaScript.tiempoRetraso;
                            DifX6 = MathF.Abs(posX6 - (diana6.position.x));
                            DifY6 = MathF.Abs(posY6 - (diana6.position.y));
                            level = 3;
                            ischanged = true;

                            //canvaResultados.SetActive(true);//EL ÚLTIMO ACTIVA EL CANVA CON LOS RESULTADOS
                            break;
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region PacienteAcostado
        if (patient == 1)
        {
            if (collider.localPosition.x > -0.3) //ESTOS DOS IFs SIRVEN PARA DETERMINAR SI EST'A TOCANDO DIANAS ARRIBA O ABAJO Y CAMBIAR ENTONCES LOS LIMITES
            {
                Debug.Log("esta izquierda");

                limXleft = (float)0.07;
                limXright = (float)-0.166;
                limYup = (float)0.06;
                limYdown = (float)-0.141;
                limZ1 = (float)0.962;
                limZ2 = (float)0.590;
                limZ3 = (float)0.38;
            }
            if (collider.localPosition.x < -0.3)
            {
                Debug.Log("esta derecha");

                limXleft = (float)-0.402;
                limXright = (float)-0.66;
                limYup = (float)0.06;
                limYdown = (float)-0.155;
                limZ1 = (float)1.07;
                limZ2 = (float)0.690;
                limZ3 = (float)0.51;
            }
            #region DianaDetector
            if (collider.localPosition.z <= limZ1 && collider.localPosition.y < limYup && collider.localPosition.y > limYdown && collider.localPosition.x < limXleft && collider.localPosition.x > limXright && fuerzas.z != 0)
            //HAY QUE SUSTITUIR LOS CEROS POR LOS VALORES LÍMITES DE LAS DIANAS SEGÚN LA VARIABLE LOCAL DE POSICIÓN DENTRO DE LA ESCENA
            {
                #region CONDICIONESPIEL
                if (collider.localPosition.z <= limZ1 && level == 1) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN EN Z LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                        case 0:
                            if (num11 >= num12)
                            {
                                diana1objetoB.SetActive(false);
                                diana2objetoB.SetActive(true);
                            }
                            if (num11 < num12)
                            {
                                diana2objetoB.SetActive(false);
                                diana1objetoB.SetActive(true);
                            }
                            //contador++;
                            angX1 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY1 = angulos.y;
                            angZ1 = angulos.z;
                            posX1 = collider.position.x;
                            posY1 = collider.position.y;
                            DifX1 = MathF.Abs(posX1 - (diana1B.position.x));
                            DifY1 = MathF.Abs(posY1 - (diana1B.position.y));
                            tiempobola1 = tiempo - pausaScript.tiempoRetraso;
                            ischanged = true;
                            break;
                        case 1:
                            diana1objetoB.SetActive(false);
                            diana2objetoB.SetActive(false);
                            if (num21 >= num22)
                            {
                                diana3objetoB.SetActive(true);
                            }
                            if (num21 < num22)
                            {
                                diana4objetoB.SetActive(true);
                            }
                            angX2 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY2 = angulos.y;
                            angZ2 = angulos.z;
                            posX2 = collider.position.x;
                            posY2 = collider.position.y;
                            tiempobola2 = tiempo - tiempobola1 - pausaScript.tiempoRetraso;
                            DifX2 = MathF.Abs(posX2 - (diana2B.position.x));
                            DifY2 = MathF.Abs(posY2 - (diana2B.position.y));
                            ischanged = true;
                            level = 2;
                            break;
                        
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
                #region CONDICIONES LA
                if (collider.localPosition.z <= limZ2 && level == 2) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN EN Z del ligamento amarillo LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                       
                        case 2:
                            if (num21 >= num22)
                            {
                                diana3objetoB.SetActive(false);
                                diana4objetoB.SetActive(true);
                            }
                            if (num21 < num22)
                            {
                                diana4objetoB.SetActive(false);
                                diana3objetoB.SetActive(true);
                            }
                            angX3 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY3 = angulos.y;
                            angZ3 = angulos.z;
                            posX3 = collider.position.x;
                            posY3 = collider.position.y;
                            tiempobola3 = tiempo - (tiempobola1 + tiempobola2) - pausaScript.tiempoRetraso;
                            DifX3 = MathF.Abs(posX3 - (diana3B.position.x));
                            DifY3 = MathF.Abs(posY3 - (diana3B.position.y));
                            ischanged = true;
                            break;
                        case 3:
                            diana4objetoB.SetActive(false);
                            diana3objetoB.SetActive(false);
                            if (num31 >= num32)
                            {
                                diana5objetoB.SetActive(true);
                            }
                            if (num31 < num32)
                            {
                                diana6objetoB.SetActive(true);
                            }
                            angX4 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY4 = angulos.y;
                            angZ4 = angulos.z;
                            posX4 = collider.position.x;
                            posY4 = collider.position.y;
                            tiempobola4 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3) - pausaScript.tiempoRetraso;
                            DifX4 = MathF.Abs(posX4 - (diana4B.position.x));
                            DifY4 = MathF.Abs(posY4 - (diana4B.position.y));
                            level = 3;
                            ischanged = true;

                            break;
                        
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
                #region CONDICIONES DM
                if (collider.localPosition.z <= limZ3 && level == 3) //AQUÍ DETERMINAR CUÁL ES LA POSICIÓN del saco dural EN Z LOCAL DEL COLLIDER
                                                                    //angulos = hapticplugin.GimbalAngles;// si ya ha tocado algo y sobrepasa el umbral de fuerzas entonces almacena los angulos con que lo hizo
                {
                    bool ischanged = false;
                    tiempoEspera = tiempo;
                    angulos = hapticplugin.GimbalAngles;//0.2 para que no sea justo al tocar sino que se not eun poco de resistencia
                    switch (contador)//para comprobar que bolita es necesita mirar el valor de contador
                    {
                        
                        case 4:
                            if (num31 >= num32)
                            {
                                diana5objetoB.SetActive(false);
                                diana6objetoB.SetActive(true);

                            }
                            if (num31 < num32)
                            {
                                diana6objetoB.SetActive(false);
                                diana5objetoB.SetActive(true);

                            }

                            angX5 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY5 = angulos.y;
                            angZ5 = angulos.z;
                            posX5 = collider.position.x;
                            posY5 = collider.position.y;
                            tiempobola5 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4) - pausaScript.tiempoRetraso;
                            DifX5 = MathF.Abs(posX5 - (diana5B.position.x));
                            DifY5 = MathF.Abs(posY5 - (diana5B.position.y));
                            ischanged = true;

                            break;
                        case 5:
                            diana6objetoB.SetActive(false);
                            diana5objetoB.SetActive(false);
                            angX6 = angulos.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
                            angY6 = angulos.y;
                            angZ6 = angulos.z;
                            posX6 = collider.position.x;
                            posY6 = collider.position.y;
                            tiempobola6 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4 + tiempobola5) - pausaScript.tiempoRetraso;
                            DifX6 = MathF.Abs(posX6 - (diana6B.position.x));
                            DifY6 = MathF.Abs(posY6 - (diana6B.position.y));
                            level = 3;
                            ischanged = true;

                            //canvaResultados.SetActive(true);//EL ÚLTIMO ACTIVA EL CANVA CON LOS RESULTADOS
                            break;
                    }
                    //#endregion
                    //pantallaVerde.SetActive(true);//para poner pantalla verde
                    if (ischanged) StartCoroutine(Wait());//esperamos 1 segundo con pantalla en verde
                                                          //pantallaVerde.SetActive(false);//quitamos pantalla en verde
                    StartCoroutine(Wait2());//esperamos dos segundos para que deje de tocar la primera bola antes de subir el contador
                                            //TIENE QUE HACER UN WAIT DE 2 SEGUNDOS
                                            //QUITARPA;NTALLA VERDE
                                            //contador++;
                    /* if (collider.position.z <= -0.016) { 
                         contador++;
                     }*/

                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region HuesoDetector
        if (collider.localPosition.z <= 0 && collider.localPosition.y < 0 && collider.localPosition.y > 0 && collider.localPosition.x < 0 && collider.localPosition.x > 0 && fuerzas.z != 0)
        //HAY QUE SUSTITUIR LOS CEROS POR LOS VALORES LÍMITES DE LAS DIANAS SEGÚN LA VARIABLE LOCAL DE POSICIÓN DENTRO DE LA ESCENA invertidos del DianaDetector
        {
            //En este caso no hace nada pero sirve para el siguiente ejercicio iluminar las dianas
        }
        #endregion

        #region EjercicioCompleto
        if (contador == 6)
        {
            //PUNTUACIÓN BOLA 1
            //DifX1 = posX1 - (num11 / 1000);

            //     DifY1 = posY1 - (num12 / 1000);
            //if ((-0.005 < DifX1 < 0.005) && (-0.005 < DifY1 < 0.005))
            //{

            // }
            if (patient == 0)
            {
                if (num11 > num12)
                {
                    distanciaD1 = (float)Math.Sqrt(Math.Pow((posX1 - diana1.position.x), 2) + Math.Pow((posY1 - diana1.position.y), 2));
                    distanciaD2 = (float)Math.Sqrt(Math.Pow((posX2 - diana2.position.x), 2) + Math.Pow((posY2 - diana2.position.y), 2));
                }
                if (num11 < num12)
                {
                    distanciaD1 = (float)Math.Sqrt(Math.Pow((posX1 - diana2.position.x), 2) + Math.Pow((posY1 - diana2.position.y), 2));
                    distanciaD2 = (float)Math.Sqrt(Math.Pow((posX2 - diana1.position.x), 2) + Math.Pow((posY2 - diana1.position.y), 2));
                }
                if (num21 > num22)
                {
                    distanciaD3 = (float)Math.Sqrt(Math.Pow((posX3 - diana3.position.x), 2) + Math.Pow((posY3 - diana3.position.y), 2));
                    distanciaD4 = (float)Math.Sqrt(Math.Pow((posX4 - diana4.position.x), 2) + Math.Pow((posY4 - diana4.position.y), 2));
                }
                if (num21 < num22)
                {
                    distanciaD3 = (float)Math.Sqrt(Math.Pow((posX3 - diana4.position.x), 2) + Math.Pow((posY3 - diana4.position.y), 2));
                    distanciaD4 = (float)Math.Sqrt(Math.Pow((posX4 - diana3.position.x), 2) + Math.Pow((posY4 - diana3.position.y), 2));
                }
                if (num31 > num32)
                {
                    distanciaD5 = (float)Math.Sqrt(Math.Pow((posX5 - diana5.position.x), 2) + Math.Pow((posY5 - diana5.position.y), 2));
                    distanciaD6 = (float)Math.Sqrt(Math.Pow((posX6 - diana6.position.x), 2) + Math.Pow((posY6 - diana6.position.y), 2));
                }
                if (num31 < num32)
                {
                    distanciaD5 = (float)Math.Sqrt(Math.Pow((posX5 - diana6.position.x), 2) + Math.Pow((posY5 - diana6.position.y), 2));
                    distanciaD6 = (float)Math.Sqrt(Math.Pow((posX6 - diana5.position.x), 2) + Math.Pow((posY6 - diana5.position.y), 2));
                }

            }
            if (patient == 1)
            {
                if (num11 > num12)
                {
                    distanciaD1 = (float)Math.Sqrt(Math.Pow((posX1 - diana1B.position.x), 2) + Math.Pow((posY1 - diana1B.position.y), 2));
                    distanciaD2 = (float)Math.Sqrt(Math.Pow((posX2 - diana2B.position.x), 2) + Math.Pow((posY2 - diana2B.position.y), 2));
                }
                if (num11 < num12)
                {
                    distanciaD1 = (float)Math.Sqrt(Math.Pow((posX1 - diana2B.position.x), 2) + Math.Pow((posY1 - diana2B.position.y), 2));
                    distanciaD2 = (float)Math.Sqrt(Math.Pow((posX2 - diana1B.position.x), 2) + Math.Pow((posY2 - diana1B.position.y), 2));
                }
                if (num21 > num22)
                {
                    distanciaD3 = (float)Math.Sqrt(Math.Pow((posX3 - diana3B.position.x), 2) + Math.Pow((posY3 - diana3B.position.y), 2));
                    distanciaD4 = (float)Math.Sqrt(Math.Pow((posX4 - diana4B.position.x), 2) + Math.Pow((posY4 - diana4B.position.y), 2));
                }
                if (num21 < num22)
                {
                    distanciaD3 = (float)Math.Sqrt(Math.Pow((posX3 - diana4B.position.x), 2) + Math.Pow((posY3 - diana4B.position.y), 2));
                    distanciaD4 = (float)Math.Sqrt(Math.Pow((posX4 - diana3B.position.x), 2) + Math.Pow((posY4 - diana3B.position.y), 2));
                }
                if (num31 > num32)
                {
                    distanciaD5 = (float)Math.Sqrt(Math.Pow((posX5 - diana5B.position.x), 2) + Math.Pow((posY5 - diana5B.position.y), 2));
                    distanciaD6 = (float)Math.Sqrt(Math.Pow((posX6 - diana6B.position.x), 2) + Math.Pow((posY6 - diana6B.position.y), 2));
                }
                if (num31 < num32)
                {
                    distanciaD5 = (float)Math.Sqrt(Math.Pow((posX5 - diana6B.position.x), 2) + Math.Pow((posY5 - diana6B.position.y), 2));
                    distanciaD6 = (float)Math.Sqrt(Math.Pow((posX6 - diana5B.position.x), 2) + Math.Pow((posY6 - diana5B.position.y), 2));
                }
            }


            tiempoTotal = tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4 + tiempobola5 + tiempobola6;
            sliderTiempo.value = tiempoTotal;
            sliderTiempo1.value = tiempobola1;
            sliderTiempo2.value = tiempobola2;
            sliderTiempo3.value = tiempobola3;
            sliderTiempo4.value = tiempobola4;
            sliderTiempo5.value = tiempobola5;
            sliderTiempo6.value = tiempobola6;

            sliderDis1.value = distanciaD1;
            sliderDis2.value = distanciaD2;
            sliderDis3.value = distanciaD3;
            sliderDis4.value = distanciaD4;
            sliderDis5.value = distanciaD5;
            sliderDis6.value = distanciaD6;

            sliderDifY1.value = DifY1;
            sliderDifY2.value = DifY2;
            sliderDifY3.value = DifY3;
            sliderDifY4.value = DifY4;
            sliderDifY5.value = DifY5;
            sliderDifY6.value = DifY6;

            tiempoMedio = tiempoTotal / 6;
            distanciaMediaX = (distanciaD1 + distanciaD1 + distanciaD3 + distanciaD4 + distanciaD5 + distanciaD6) / 6;
            distanciaMediaY = (DifY1 + DifY2 + DifY3 + DifY4 + DifY5 + DifY6) / 6;
            sliderTiempoMedio.value = tiempoMedio;
            sliderDistanciaMediaX.value = distanciaMediaX;
            sliderDistanciaMediaY.value = distanciaMediaY;
            //posicionReposo.SetActive(true);
            readyForResults = true;
            posicionReposoCheck();


            //resultados.SetActive(true);
            /* if (sliderTiempo.value > 70)
             {
                 fill.color = verde;
             }
             else if (valorVariable >= 40 && valorVariable <= 70)
             {
                 fill.color = amarillo;
             }
             else
             {
                 fill.color = rojo;
             }*/

            //pantallaResultados.SetActive(true);//se activa cuando hayas toacado todas las bolitas el canva con todos los resultados
            //faltaría ver si está entre tanto y tanto que salga verde amarillo o azul o ver como hacer la ludificacion de esto, el sitema de puntuación
            //poner que introduzcas nombre y te deje guardarlo


            #endregion
        }
    }

    #region Waits y LLamadas
    IEnumerator Wait()
    {
        isWaiting = true;
        yield return new WaitForSeconds(2);
        //pantallaVerde.SetActive(false);
        contador++;
        isWaiting = false;
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
    }
    public void LoadScene1()
    {
        SceneManager.LoadScene("MENU");
    }
    public void posicionReposoCheck()
    {
        if (readyForResults == true)
        {
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(ShowResultados());
            //visualMesh.SetActive(false);
        }
        //condicion = true;
        /*while(condicion == true)
        {
            if ((collider.position.y >= 0.068) && (collider.position.z <= -0.124))
            {
                //animResultados.SetBool("Reposo",true);
                //resultados.SetActive(true);
                esferaResultados.SetActive(true) ;
                condicion = false;
                StartCoroutine(ShowResultados());
            }
            else
            {
                condicion= false;
            }
        }*/
    }
    IEnumerator ShowResultados()
    {
        yield return new WaitForSeconds(2);
        resultados.SetActive(true);
        saveButton.SetActive(true);
        meshHD1.enabled = true;
        meshHD2.enabled = true;
        meshHD3.enabled = true;
        meshHD4.enabled = true;
        meshHD5.enabled = true;
        meshHD6.enabled = true;
        meshHD7.enabled = true;
        meshHD8.enabled = true;
        meshHD9.enabled = true;
        meshaguja.enabled = false;
        meshmano1.enabled = false;
        meshmano2.enabled = false;
        meshmano3.enabled = false;

        baseReposo.SetActive(true);

        visualMesh.SetActive(false);
        visualMesh2.SetActive(false);
        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);


    }
    IEnumerator quitaresfera()
    {
        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);
    }
    #endregion
}