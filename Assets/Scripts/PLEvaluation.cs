using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
using UnityEngine.Animations;
public class PLEvaluation : MonoBehaviour
{
    #region VARIABLES
    public static BS2Controller instancia;

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
    public float posZ6;
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
    public Slider sliderDifX1;
    public Slider sliderDifX2;
    public Slider sliderDifX3;
    public Slider sliderDifX4;
    public Slider sliderDifX5;
    public Slider sliderDifX6;
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

    public int level;
    public float patient;

    public GameObject d1Ref;
    public GameObject d2Ref;
    public GameObject d3Ref;
    public GameObject d4Ref;
    public Renderer d1Refmaterial;
    public Renderer d2Refmaterial;
    public Renderer d3Refmaterial;
    public Renderer d4Refmaterial;
    public GameObject d1BRef;
    public GameObject d2BRef;
    public GameObject d3BRef;
    public GameObject d4BRef;
    public Renderer d1BRefmaterial;
    public Renderer d2BRefmaterial;
    public Renderer d3BRefmaterial;
    public Renderer d4BRefmaterial;

    public int desviaciones;
    public int anglesfails;
    public bool desviado;
    public int localizadorA;
    public Material rojotransaprente;
    public Material gristransparente;
    public bool tocando;

    public bool isOut;
    public bool isIn;
    public float difAngleX;
    public float disfAngleY;
    public float angleInY;
    public float angleInX;
    public float angleInZ1;
    public float angleInZ2;
    public float angleInZ3;
    public float angleInZ4;
    public float angleInZ5;
    public float angleInZ6;



    public float distanciaD1;
    public float distanciaD2;
    public float distanciaD3;
    public float distanciaD4;
    public float distanciaD5;
    public float distanciaD6;

    public int devOn1;
    public int devOn2;
    public int devOn3;
    public int devOn4;
    public int devOn5;
    public int devOn6;
    public int devAng1;
    public int devAng2;
    public int devAng3;
    public int devAng4;
    public int devAng5;
    public int devAng6;

    public bool entrando;
    public int esperaAngles;

    public float resistanceLimit;
    public float forceValue;

    public bool readyForNext;
    public bool deviationWaiting;
    public bool deviationWaitingAng;

    public float posactx;
    public float posacty;
    public float posdpsx;
    public float posdpsy;
    public float angactx;
    public float angacty;
    public float angdpsx;
    public float angdpsy;
    public float acumposx;
    public float acumposy;
    public float acumangx;
    public float acumangy;
    public float acumTotal;
    public bool acumReady;

    public Slider sliderDifY1Angles;
    public Slider sliderDifY2Angles;
    public Slider sliderDifY3Angles;
    public Slider sliderDifY4Angles;
    public Slider sliderDifY5Angles;
    public Slider sliderDifY6Angles;

    public Slider sliderAcumAng;
    public Slider sliderAcumPos;

    public float acumBevel;
    public float angdpsz;
    public float angactz;

    public float acumpos;

    public GameObject buttonSave;
    #endregion
    void Start()
    {
        StartCoroutine(quitaresfera());
        readyForResults = false;
        readyForNext = true;
        acumReady = true;
        hapticplugin = FindObjectOfType<HapticPlugin>();//para encontrar el script hapticplugin dentro del objeto del hptio
        contador = 0;
        tiempo = 0;
        checkInit = 0;
        level = 1;
        patient = ScenesInformation.instancia.opPatientPosition;
        anglesfails = 0;
        devOn1 = 0;
        devOn2 = 0;
        devOn3 = 0;
        devOn4 = 0;
        devOn5 = 0;
        devOn6 = 0;
        entrando = false;
        esperaAngles = 1;
        acumBevel = 0;
        // Establece el valor mínimo y máximo del slider
        //sliderTiempo.minValue = valorMinimoTiempo;
        //sliderTiempo.maxValue = valorMaximoTiempo;

        System.Random aleatorio = new System.Random();
        //en un futuro serán de 12 números o de 18 en función si también hacemos eje z



        num11 = aleatorio.Next(1, 100);
        num12 = aleatorio.Next(1, 100);
        num21 = aleatorio.Next(1, 100);
        num22 = aleatorio.Next(1, 100);
        num31 = aleatorio.Next(1, 100);
        num32 = aleatorio.Next(1, 100);
        desviaciones = 0;
        desviado = false;
        //AÑADIR ESTO PARA DETERMINAR QUE DIANA VA PRIMERO
        if (num11 >= num12)
        {
            if (patient == 0)
            {
                diana1objeto.SetActive(true);

            }
            if (patient == 1)
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
          
        

        


        #region Acumulación de diferencias

        if (collider.localPosition.z < limZ1&&acumReady==true&&contador>=2)
        {
            posactx = collider.localPosition.x;
            posacty = collider.localPosition.y;
            angactx = hapticplugin.GimbalAngles.x;
            angacty = hapticplugin.GimbalAngles.y;
            angactz = hapticplugin.GimbalAngles.z;

            StartCoroutine(acumulada());
            acumReady = false;
        }

        #endregion
        #region Nueva Deteccion de Desplazamientos

        if (patient == 0 && readyForNext == true)
        {
            if (isWaiting == false)
            {
                Debug.Log("dentro del primer if detector");
                    if (contador == 2 && collider.localPosition.z < 0.95 && (collider.localPosition.x <= -0.126 || collider.localPosition.x >= 0.093 || collider.localPosition.y >= 1.097 || collider.localPosition.y <= 0.856))
                    {
                        MoveDeviation(6);

                    }
            }

        }
        if (patient == 1 && readyForNext == true)
        {
            if (isWaiting == false)//esto funciona para sentado ya costadoluego habr'a que ponerle otra condicion si queremos que funcione solo para sentado
            {
                Debug.Log("dentro del primer if detector");

                    if (contador == 2 && collider.localPosition.z < 0.962 && (collider.localPosition.x <= -0.166 || collider.localPosition.x >= 0.07 || collider.localPosition.y >= 0.06 || collider.localPosition.y <= -0.141))
                    {
                        d2BRefmaterial.material = rojotransaprente;
                        //targetsDeleter();
                        MoveDeviation(6);

                    }
            }
        }
        #endregion
        #region AnglesDetector
        if ((contador >= 2 || contador < 6) && readyForNext == true)//de esta manera solo comprueba los angulos despues de tocar las dos primeras dianas
        {
            if (isOut == true && collider.localPosition.z <= limZ1)
            {//detecta que esta fuera y entra cogiendo los angulos al entrar
                angleInX = hapticplugin.GimbalAngles.x;
                angleInY = hapticplugin.GimbalAngles.y;
                isOut = false;
                Debug.Log("Angles detector step2");

            }
            if (isOut == false && collider.localPosition.z > limZ1)//vuelve a detectar que salio para poder coger los nuevos angulos
            {
                isOut = true;
            }
            if (isOut == false && desviado == false)
            {
                Debug.Log("Angles detector step3");

                difAngleX = MathF.Abs(hapticplugin.GimbalAngles.x - angleInX);
                disfAngleY = MathF.Abs(hapticplugin.GimbalAngles.y - angleInY);
                if (patient == 0)//sentado
                {
                    if (contador == 2 || contador == 3)
                    {
                        if (num21 >= num22)
                        {
                            if (contador == 2 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d1Refmaterial.material = rojotransaprente;
                                AngDeviation(3);
                                targetsDeleter();


                            }
                            if (contador == 3 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d2Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(4);




                            }

                        }
                        if (num22 >= num21)
                        {
                            if (contador == 2 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d2Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(3);


                            }
                            if (contador == 3 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d1Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(4);


                            }

                        }
                    }
                    if (contador == 4 || contador == 5)
                    {
                        if (num31 >= num32)
                        {
                            if (contador == 4 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d3Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(5);


                            }
                            if (contador == 5 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d4Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(6);


                            }

                        }
                        if (num32 >= num31)
                        {
                            if (contador == 4 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d4Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(5);


                            }
                            if (contador == 5 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d3Refmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(6);


                            }

                        }
                    }
                }
                if (patient == 1)//acostado
                {
                    if (contador == 2 || contador == 3)
                    {
                        if (num21 >= num22)
                        {
                            if (contador == 2 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d2BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(3);


                            }
                            if (contador == 3 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d1BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(4);


                            }

                        }
                        if (num22 >= num21)
                        {
                            if (contador == 2 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d1BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(3);


                            }
                            if (contador == 3 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d2BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(4);


                            }

                        }
                    }
                    if (contador == 4 || contador == 5)
                    {
                        if (num31 >= num32)
                        {
                            if (contador == 4 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d4BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(5);



                            }
                            if (contador == 5 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d3BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(6);


                            }

                        }
                        if (num32 >= num31)
                        {
                            if (contador == 4 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d3BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(5);


                            }
                            if (contador == 5 && (difAngleX > 15 || disfAngleY > 15))
                            {
                                d4BRefmaterial.material = rojotransaprente;
                                targetsDeleter();
                                AngDeviation(6);


                            }

                        }
                    }
                }
                /*if (difAngleX > 15 || disfAngleY > 15)
                {

                    Debug.Log("fallo angles");

                    anglesfails++;
                    desviado = true;
                    StartCoroutine(desviadoController());

                    if (collider.localPosition.z > limZ2)
                    {
                        if (localizadorA == 1)
                        {
                            if (patient == 1)
                            {
                                d1BRefmaterial.material = rojotransaprente;
                            }
                            d1Refmaterial.material = rojotransaprente;
                            devOn3++;
                        }
                        if (localizadorA == 0)
                        {
                            if (patient == 1)
                            {
                                d2BRefmaterial.material = rojotransaprente;
                            }
                            d2Refmaterial.material = rojotransaprente;
                            devOn4++;
                        }
                    }
                    if (collider.localPosition.z < limZ2)
                    {

                        if (localizadorA == 1)
                        {
                            if (patient == 1)
                            {
                                d3BRefmaterial.material = rojotransaprente;
                            }
                            d3Refmaterial.material = rojotransaprente;
                            devOn5++;
                        }
                        if (localizadorA == 0)
                        {
                            if (patient == 1)
                            {
                                d4BRefmaterial.material = rojotransaprente;
                            }
                            d4Refmaterial.material = rojotransaprente;
                            devOn6++;
                        }
                    }
                }*/

            }
        }
        #endregion
        #region Bisel
        if (collider.localPosition.z <= limZ1&&readyForNext==true&&collider.localPosition.z>(limZ1-0.1))
        {
            switch (contador)
            {
                case 0:
                    angleInZ1 = hapticplugin.GimbalAngles.z;
                    break;
                case 1:
                    angleInZ2 = hapticplugin.GimbalAngles.z;
                    break;
                case 2:
                    angleInZ3 = hapticplugin.GimbalAngles.z;
                    break;
                case 3:
                    angleInZ4 = hapticplugin.GimbalAngles.z;
                    break;
                case 4:
                    angleInZ5 = hapticplugin.GimbalAngles.z;
                    break;
                case 5:
                    angleInZ6 = hapticplugin.GimbalAngles.z;
                    break;
            }
        }
        #endregion
        #region EjercicioCompleto
        if (contador == 6)
        {
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
            //PUNTUACIÓN BOLA 1
            //DifX1 = posX1 - (num11 / 1000);

            //     DifY1 = posY1 - (num12 / 1000);
            //if ((-0.005 < DifX1 < 0.005) && (-0.005 < DifY1 < 0.005))
            //{

            // }
            tiempoTotal = tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4 + tiempobola5 + tiempobola6;
            sliderTiempo.value = tiempoTotal;
            if (patient == 0)
            {
                float difAngZ1 = (Mathf.Abs(90 - angleInZ1))<(Mathf.Abs(-90-angleInZ1))? (Mathf.Abs(90 - angleInZ1)) : (Mathf.Abs(-90 - angleInZ1));
                float difAngZ2 = (Mathf.Abs(90 - angleInZ2)) < (Mathf.Abs(-90 - angleInZ2)) ? (Mathf.Abs(90 - angleInZ2)) : (Mathf.Abs(-90 - angleInZ2));
                float difAngZ3 = (Mathf.Abs(90 - angleInZ3)) < (Mathf.Abs(-90 - angleInZ3)) ? (Mathf.Abs(90 - angleInZ3)) : (Mathf.Abs(-90 - angleInZ3));
                float difAngZ4 = (Mathf.Abs(90 - angleInZ4)) < (Mathf.Abs(-90 - angleInZ4)) ? (Mathf.Abs(90 - angleInZ4)) : (Mathf.Abs(-90 - angleInZ4));
                float difAngZ5 = (Mathf.Abs(90 - angleInZ5)) < (Mathf.Abs(-90 - angleInZ5)) ? (Mathf.Abs(90 - angleInZ5)) : (Mathf.Abs(-90 - angleInZ5));
                float difAngZ6 = (Mathf.Abs(90 - angleInZ6)) < (Mathf.Abs(-90 - angleInZ6)) ? (Mathf.Abs(90 - angleInZ6)) : (Mathf.Abs(-90 - angleInZ6));
                sliderTiempo1.value = difAngZ1;
                sliderTiempo2.value = difAngZ2;
                sliderTiempo3.value = difAngZ3;
                sliderTiempo4.value = difAngZ4;
                sliderTiempo5.value = difAngZ5;
                sliderTiempo6.value = difAngZ6;
            }
            if (patient == 1)
            {
                float difAngZ1 = Mathf.Abs(0 - angleInZ1);
                float difAngZ2 = Mathf.Abs(0 - angleInZ2);
                float difAngZ3 = Mathf.Abs(0 - angleInZ3);
                float difAngZ4 = Mathf.Abs(0 - angleInZ4);
                float difAngZ5 = Mathf.Abs(0 - angleInZ5);
                float difAngZ6 = Mathf.Abs(0 - angleInZ6);
                sliderTiempo1.value = difAngZ1;
                sliderTiempo2.value = difAngZ2;
                sliderTiempo3.value = difAngZ3;
                sliderTiempo4.value = difAngZ4;
                sliderTiempo5.value = difAngZ5;
                sliderTiempo6.value = difAngZ6;
            }

            sliderDifX1.value = distanciaD1;
            sliderDifX2.value = distanciaD2;
            sliderDifX3.value = distanciaD3;
            sliderDifX4.value = distanciaD4;
            sliderDifX5.value = distanciaD5;
            sliderDifX6.value = distanciaD6;

            sliderDifY1.value = devOn1;
            sliderDifY2.value = devOn2;
            sliderDifY3.value = devOn3;
            sliderDifY4.value = devOn4;
            sliderDifY5.value = devOn5;
            sliderDifY6.value = devOn6;

            sliderDifY1Angles.value = devAng1;
            sliderDifY2Angles.value = devAng2;
            sliderDifY3Angles.value = devAng3;
            sliderDifY4Angles.value = devAng4;
            sliderDifY5Angles.value = devAng5;
            sliderDifY6Angles.value = devAng6;

            tiempoMedio = acumBevel;
            distanciaMediaX = (distanciaD1 + distanciaD2 + distanciaD3 + distanciaD4 + distanciaD5 + distanciaD6) / 6;
            distanciaMediaY = devOn1 + devOn2 + devOn3 + devOn4 + devOn5 + devOn6 + devAng1 + devAng2 + devAng3 + devAng4 + devAng5 + devAng6;
            //distanciaMediaY = desviaciones + anglesfails;
            sliderTiempoMedio.value = tiempoMedio;
            sliderDistanciaMediaX.value = distanciaMediaX;
            sliderDistanciaMediaY.value = distanciaMediaY;
            acumTotal = acumangx + acumangy;
            sliderAcumAng.value = acumTotal;
            acumpos = acumposx + acumposy;
            sliderAcumPos.value = acumposx + acumposy;
            //posicionReposo.SetActive(true);
            readyForResults = true;
            desviado = true;
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


        }
        #endregion
    }


    #region Waits y LLamadas

    public void finExercise()
    {
        angX6 = hapticplugin.GimbalAngles.x;// de esta manera almaceno los ángulos de inserción ojo que puede ser jpint no gimbal tengo que mirar
        angY6 = hapticplugin.GimbalAngles.y;
        angZ6 = hapticplugin.GimbalAngles.z;
        posX6 = collider.position.x;
        posY6 = collider.position.y;
        posZ6 = collider.position.z;
        tiempobola6 = tiempo - (tiempobola1 + tiempobola2 + tiempobola3 + tiempobola4 + tiempobola5) - pausaScript.tiempoRetraso;
        DifX6 = MathF.Abs(posX6 - (diana6.position.x));
        DifY6 = MathF.Abs(posY6 - (diana6.position.y));
        level = 3;
        desviado = true;
        distanciaD6 = (float)Math.Sqrt(Math.Pow((posX6 - diana6.position.x), 2) + Math.Pow((posY6 - diana6.position.y), 2));
        acumTotal = acumangx + acumangy;
        acumTotal = acumangx + acumangy;
        //en DevOn6 están los fallos en desplazamientos durante el ejericio
        readyForResults = true;
        posicionReposoCheck();

    }
    IEnumerator acumulada()
    {

        yield return new WaitForSeconds(2);
        posdpsx = collider.localPosition.x;
        posdpsy = collider.localPosition.y;
        angdpsx = hapticplugin.GimbalAngles.x;
        angdpsy = hapticplugin.GimbalAngles.y;
        angdpsz = hapticplugin.GimbalAngles.z;

        acumposx = acumposx + MathF.Abs(posdpsx - posactx);
        acumposy = acumposy + MathF.Abs(posdpsy - posacty);
        acumangx = acumangx + MathF.Abs(angdpsx - angactx);
        acumangy = acumangy + MathF.Abs(angdpsy - angacty);
        acumBevel=acumBevel+ MathF.Abs(angdpsz - angactz);
        acumReady = true;
    }
    public void MoveDeviation(int diana)
    {
        Debug.Log("Desviación de movimiento papi estamos clear tu sabes así sí rey somo reales" + diana.ToString());
        if (deviationWaiting == false)
        {
            deviationWaiting = true;
            Debug.Log("Entré por la condición solo deberíamos haber uno para " + diana.ToString());
            switch (diana)
            {
                case 3:
                    devOn3++;
                    Debug.Log("Entré al 3");
                    break;
                case 4:
                    devOn4++;
                    Debug.Log("Entré al 4");

                    break;
                case 5:
                    devOn5++;
                    Debug.Log("Entré al 5");

                    break;
                case 6:
                    devOn6++;
                    Debug.Log("Entré al 6");

                    break;


            }
            //readyForNext = false;
            //deviationWaiting = true;
            StartCoroutine(waitingDev());
        }
    }
    public void AngDeviation(int diana)
    {
        if (deviationWaitingAng == false)
        {
            deviationWaitingAng = true;

            switch (diana)
            {
                case 3:
                    devAng3++;
                    break;
                case 4:
                    devAng4++;
                    break;
                case 5:
                    devAng5++;
                    break;
                case 6:
                    devAng5++;
                    break;


            }
            //deviationWaiting = true;
            StartCoroutine(waitingDevAng());
        }
    }
    IEnumerator waitingDev()
    {
        yield return new WaitForSeconds(2);
        deviationWaiting = false;
        //readyForNext = true;
    }
    IEnumerator waitingDevAng()
    {
        yield return new WaitForSeconds(2);
        deviationWaitingAng = false;
    }
    IEnumerator Wait()
    {
        readyForNext = false;
        isWaiting = true;
        yield return new WaitForSeconds(4);
        //pantallaVerde.SetActive(false);
        contador++;
        Debug.Log("dentro del wait");

        isWaiting = false;
    }
    IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
    }
    IEnumerator entradaSalida()
    {
        yield return new WaitForSeconds(1);
        entrando = true;

    }
    public void targetsDeleter()
    {
        diana1objeto.SetActive(false);
        diana2objeto.SetActive(false);
        diana3objeto.SetActive(false);
        diana4objeto.SetActive(false);
        diana5objeto.SetActive(false);
        diana6objeto.SetActive(false);

        diana1objetoB.SetActive(false);
        diana2objetoB.SetActive(false);
        diana3objetoB.SetActive(false);
        diana4objetoB.SetActive(false);
        diana5objetoB.SetActive(false);
        diana6objetoB.SetActive(false);

        readyForNext = false;

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
        yield return new WaitForSeconds(3);
        resultados.SetActive(true);
        buttonSave.SetActive(true);
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
        visualMesh2.SetActive(false);
        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);


    }
    IEnumerator quitaresfera()
    {
        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);
    }
    IEnumerator desviadoController()
    {
        yield return new WaitForSeconds(2);
        desviado = false;
    }



    #endregion
}