using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;

public class BS2SliderColor : MonoBehaviour
{
    public Slider sliderrojoPrefab;//es el del timepo total
    public Slider sliderTiempo1;
    public Slider sliderTiempo2;
    public Slider sliderTiempo3;
    public Slider sliderTiempo4;
    public Slider sliderTiempo5;
    public Slider sliderTiempo6;
    public Image fillSliderTiempo1;
    public Image fillSliderTiempo2;
    public Image fillSliderTiempo3;
    public Image fillSliderTiempo4;
    public Image fillSliderTiempo5;
    public Image fillSliderTiempo6;
    public Image fillSlider;
    public ControladorDianas ControladorDianas;
    public Slider sliderDistancia1X;
    public Image fillDistancia1X;
    public Slider sliderDistancia2X;
    public Image fillDistancia2X;
    public Slider sliderDistancia3X;
    public Image fillDistancia3X;
    public Slider sliderDistancia4X;
    public Image fillDistancia4X;
    public Slider sliderDistancia5X;
    public Image fillDistancia5X;
    public Slider sliderDistancia6X;
    public Image fillDistancia6X;
    public float slidervalueprueba;
    /*public float valueSlider;
    public Transform sliderUbi;*/
    // Start is called before the first frame update
    public Slider sliderDistancia1Y;
    public Image fillDistancia1Y;
    public Slider sliderDistancia2Y;
    public Image fillDistancia2Y;
    public Slider sliderDistancia3Y;
    public Image fillDistancia3Y;
    public Slider sliderDistancia4Y;
    public Image fillDistancia4Y;
    public Slider sliderDistancia5Y;
    public Image fillDistancia5Y;
    public Slider sliderDistancia6Y;
    public Image fillDistancia6Y;
    public Slider sliderDistancia7Y;
    public Image fillDistancia7Y;
    public Slider sliderDistancia8Y;
    public Image fillDistancia8Y;
    public Slider sliderDistancia9Y;
    public Image fillDistancia9Y;
    public Slider sliderDistancia10Y;
    public Image fillDistancia10Y;
    public Slider sliderDistancia11Y;
    public Image fillDistancia11Y;
    public Slider sliderDistancia12Y;
    public Image fillDistancia12Y;
    /*public float tiempoMedio;
    public float distanciaMediaX;
    public float distanciaMediaY;*/
    public Slider sliderTiempoMedio;
    public Slider sliderDistanciaMediaX;
    public Slider sliderDistanciaMediaY;
    public Image fillTiempoMedio;
    public Image fillDistanciaMediaX;
    public Image fillDistanciaMediaY;
    public GameObject verdex1;
    public GameObject amarillox1;
    public GameObject verdeY1;
    public GameObject amarilloY1;
    public GameObject amarillot1;
    public GameObject verdet1;

    public GameObject verdex2;
    public GameObject amarillox2;
    public GameObject verdeY2;
    public GameObject amarilloY2;
    public GameObject amarillot2;
    public GameObject verdet2;

    public GameObject verdex3;
    public GameObject amarillox3;
    public GameObject verdeY3;
    public GameObject amarilloY3;
    public GameObject amarillot3;
    public GameObject verdet3;

    public GameObject verdex4;
    public GameObject amarillox4;
    public GameObject verdeY4;
    public GameObject amarilloY4;
    public GameObject amarillot4;
    public GameObject verdet4;

    public GameObject verdex5;
    public GameObject amarillox5;
    public GameObject verdeY5;
    public GameObject amarilloY5;
    public GameObject amarillot5;
    public GameObject verdet5;

    public GameObject verdex6;
    public GameObject amarillox6;
    public GameObject verdeY6;
    public GameObject amarilloY6;
    public GameObject amarillot6;
    public GameObject verdet6;

    public GameObject verdeY7;
    public GameObject amarilloY7;
    public GameObject verdeY8;
    public GameObject amarilloY8;
    public GameObject amarilloY9;
    public GameObject verdeY9;
    public GameObject amarilloY10;
    public GameObject verdeY10;
    public GameObject amarilloY11;
    public GameObject verdeY11;
    public GameObject amarilloY12;
    public GameObject verdeY12;

    public GameObject verdeDH;
    public GameObject amarilloDH;
    public GameObject verdeDV;
    public GameObject amarilloDV;
    public GameObject amarilloTM;
    public GameObject verdetTM;
    public GameObject amarilloTT;
    public GameObject verdetTT;

    public TMP_InputField NUMX1;
    public TMP_InputField NUMX2;
    public TMP_InputField NUMX3;
    public TMP_InputField NUMX4;
    public TMP_InputField NUMX5;
    public TMP_InputField NUMX6;
    public TMP_InputField NUMY1;
    public TMP_InputField NUMY2;
    public TMP_InputField NUMY3;
    public TMP_InputField NUMY4;
    public TMP_InputField NUMY5;
    public TMP_InputField NUMY6;
    public TMP_InputField NUMY7;
    public TMP_InputField NUMY8;
    public TMP_InputField NUMY9;
    public TMP_InputField NUMY10;
    public TMP_InputField NUMY11;
    public TMP_InputField NUMY12;

    public TMP_InputField NUMT1;
    public TMP_InputField NUMT2;
    public TMP_InputField NUMT3;
    public TMP_InputField NUMT4;
    public TMP_InputField NUMT5;
    public TMP_InputField NUMT6;
    public TMP_InputField NUMDV;
    public TMP_InputField NUMDH;
    public TMP_InputField NUMTM;
    public TMP_InputField NUMTT;
    public TMP_InputField NUMTM2;
    public TMP_InputField NUMTM3;


    public Slider sliderAcumAng;
    public Slider sliderAcumPos;

    /*public Image marcaverde1;
    public Image marcaverde12;
    public Image marcaverde13;
    public Image marcaamarilla1;
    public Image marcaamarilla12;
    public Image marcaamarilla13;*/


    void Start()
    {
        /*GameObject sliderGO = Instantiate(sliderrojoPrefab, sliderUbi); // Instanciar el Slider
        Slider slider = sliderGO.GetComponent<Slider>(); // Obtener el componente Slider

        slider.value = valueSlider;*/ // Establecer el valor inicial del Slider
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void cambioColorTiempoTotal()
    {
        string formatotT = sliderrojoPrefab.value.ToString("0.0");
        NUMTT.text = formatotT.Substring(0, formatotT.Length - 1) + "s";
        if (sliderrojoPrefab.value <= 0)
        {
            fillSlider.color = Color.green;
        }
        if (sliderrojoPrefab.value > 3000 && sliderrojoPrefab.value <= 3000)
        {
            fillSlider.color = Color.yellow;
            verdetTT.SetActive(true);
        }
        if (sliderrojoPrefab.value > 3000)
        {
            fillSlider.color = Color.red;
            verdetTT.SetActive(true);
            amarilloTT.SetActive(true);
        }
    }
    public void cambioColorTiempo1()
    {
        //string formatoT1 = sliderTiempo1.value.ToString();
        string formatot1 = sliderTiempo1.value.ToString("0.0");
        NUMT1.text = formatot1.Substring(0, formatot1.Length - 1) + "s";

        if (sliderTiempo1.value <= 0)
        {
            fillSliderTiempo1.color = Color.green;
        }
        if (sliderTiempo1.value > 3000 && sliderTiempo1.value <= 3000)
        {
            fillSliderTiempo1.color = Color.yellow;
            verdet1.SetActive(true);
        }
        if (sliderTiempo1.value > 3000)
        {
            fillSliderTiempo1.color = Color.red;
            verdet1.SetActive(true);
            amarillot1.SetActive(true);

        }
    }
    public void cambioColorTiempo2()
    {
        string formatot2 = sliderTiempo2.value.ToString("0.0");
        NUMT2.text = formatot2.Substring(0, formatot2.Length - 1) + "s";

        if (sliderTiempo2.value <= 0)
        {
            fillSliderTiempo2.color = Color.green;

        }
        if (sliderTiempo2.value > 3000 && sliderTiempo2.value <= 3000)
        {
            fillSliderTiempo2.color = Color.yellow;
            verdet2.SetActive(true);
        }
        if (sliderTiempo2.value > 3000)
        {
            fillSliderTiempo2.color = Color.red;
            verdet2.SetActive(true);
            amarillot2.SetActive(true);
        }
    }
    public void cambioColorTiempo3()
    {
        string formatot3 = sliderTiempo3.value.ToString("0.0");
        NUMT3.text = formatot3.Substring(0, formatot3.Length - 1) + "s";

        if (sliderTiempo3.value <= 0)
        {
            fillSliderTiempo3.color = Color.green;
        }
        if (sliderTiempo3.value > 3000 && sliderTiempo3.value <= 3000)
        {
            fillSliderTiempo3.color = Color.yellow;
            verdet3.SetActive(true);
        }
        if (sliderTiempo3.value > 3000)
        {
            fillSliderTiempo3.color = Color.red;
            verdet3.SetActive(true);
            amarillot3.SetActive(true);
        }
    }
    public void cambioColorTiempo4()
    {
        string formatot4 = sliderTiempo4.value.ToString("0.0");
        NUMT4.text = formatot4.Substring(0, formatot4.Length - 1) + "s";

        if (sliderTiempo4.value <= 0)
        {
            fillSliderTiempo4.color = Color.green;
        }
        if (sliderTiempo4.value > 3000 && sliderTiempo4.value <= 3000)
        {
            fillSliderTiempo4.color = Color.yellow;
            verdet4.SetActive(true);
        }
        if (sliderTiempo4.value > 3000)
        {
            fillSliderTiempo4.color = Color.red;
            verdet4.SetActive(true);
            amarillot4.SetActive(true);
        }
    }
    public void cambioColorTiempo5()
    {
        string formatot5 = sliderTiempo5.value.ToString("0.0");
        NUMT5.text = formatot5.Substring(0, formatot5.Length - 1) + "s";

        if (sliderTiempo5.value <= 0)
        {
            fillSliderTiempo5.color = Color.green;
        }
        if (sliderTiempo5.value > 3000 && sliderTiempo5.value <= 3000)
        {
            fillSliderTiempo5.color = Color.yellow;
            verdet5.SetActive(true);
        }
        if (sliderTiempo5.value > 3000)
        {
            fillSliderTiempo5.color = Color.red;
            verdet5.SetActive(true);
            amarillot5.SetActive(true);
        }
    }
    public void cambioColorTiempo6()
    {
        string formatot6 = sliderTiempo6.value.ToString("0.0");
        NUMT6.text = formatot6.Substring(0, formatot6.Length - 1) + "s";

        if (sliderTiempo6.value <= 0)
        {
            fillSliderTiempo6.color = Color.green;
        }
        if (sliderTiempo6.value > 3000 && sliderTiempo6.value <= 3000)
        {
            fillSliderTiempo6.color = Color.yellow;
            verdet6.SetActive(true);
        }
        if (sliderTiempo6.value > 3000)
        {
            fillSliderTiempo6.color = Color.red;
            verdet6.SetActive(true);
            amarillot6.SetActive(true);
        }
    }
    public void sliderDistancia1Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        Debug.Log("sliderDistancia1Xmet");
        string formatox1 = (sliderDistancia1X.value * 1000).ToString("0.00");
        NUMX1.text = formatox1.Substring(0, formatox1.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDistancia1X.value <= 0.0025)
        {
            fillDistancia1X.color = Color.green;
        }
        if (sliderDistancia1X.value > 0.0025 && sliderDistancia1X.value <= 0.005)
        {
            fillDistancia1X.color = Color.yellow;
            verdex1.SetActive(true);

        }
        if (sliderDistancia1X.value > 0.005)
        {
            fillDistancia1X.color = Color.red;
            verdex1.SetActive(true);
            amarillox1.SetActive(true);

        }
    }
    public void sliderDistancia2Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox2 = (sliderDistancia2X.value * 1000).ToString("0.00");
        NUMX2.text = formatox2.Substring(0, formatox2.Length - 1) + "mm";
        if (sliderDistancia2X.value <= 0.0025)
        {
            fillDistancia2X.color = Color.green;

        }
        if (sliderDistancia2X.value > 0.0025 && sliderDistancia2X.value <= 0.005)
        {
            fillDistancia2X.color = Color.yellow;
            verdex2.SetActive(true);


        }
        if (sliderDistancia2X.value > 0.005)
        {
            fillDistancia2X.color = Color.red;
            verdex2.SetActive(true);
            amarillox2.SetActive(true);

        }
    }
    public void sliderDistancia3Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox3 = (sliderDistancia3X.value * 1000).ToString("0.00");
        NUMX3.text = formatox3.Substring(0, formatox3.Length - 1) + "mm";
        if (sliderDistancia3X.value <= 0.0025)
        {
            fillDistancia3X.color = Color.green;
        }
        if (sliderDistancia3X.value > 0.0025 && sliderDistancia3X.value <= 0.005)
        {
            fillDistancia3X.color = Color.yellow;
            verdex3.SetActive(true);
        }
        if (sliderDistancia3X.value > 0.005)
        {
            fillDistancia3X.color = Color.red;
            verdex3.SetActive(true);
            amarillox3.SetActive(true);

        }
    }
    public void sliderDistancia4Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox4 = (sliderDistancia4X.value * 1000).ToString("0.00");
        NUMX4.text = formatox4.Substring(0, formatox4.Length - 1) + "mm";
        if (sliderDistancia4X.value <= 0.0025)
        {
            fillDistancia4X.color = Color.green;
        }
        if (sliderDistancia4X.value > 0.0025 && sliderDistancia4X.value <= 0.005)
        {
            fillDistancia4X.color = Color.yellow;
            verdex4.SetActive(true);

        }
        if (sliderDistancia4X.value > 0.005)
        {
            fillDistancia4X.color = Color.red;
            verdex4.SetActive(true);
            amarillox4.SetActive(true);
        }
    }
    public void sliderDistancia5Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox5 = (sliderDistancia5X.value * 1000).ToString("0.00");
        NUMX5.text = formatox5.Substring(0, formatox5.Length - 1) + "mm";
        if (sliderDistancia5X.value <= 0.0025)
        {
            fillDistancia5X.color = Color.green;
        }
        if (sliderDistancia5X.value > 0.0025 && sliderDistancia5X.value <= 0.005)
        {
            fillDistancia5X.color = Color.yellow;
            verdex5.SetActive(true);

        }
        if (sliderDistancia5X.value > 0.005)
        {
            fillDistancia5X.color = Color.red;
            verdex5.SetActive(true);
            amarillox5.SetActive(true);
        }
    }
    public void sliderDistancia6Xmet()
    {
        string formatox6 = (sliderDistancia6X.value * 1000).ToString("0.00");
        NUMX6.text = formatox6.Substring(0, formatox6.Length - 1) + "mm";

        if (sliderDistancia6X.value <= 0.0025)
        {
            fillDistancia6X.color = Color.green;
        }
        if (sliderDistancia6X.value > 0.0025 && sliderDistancia6X.value <= 0.005)
        {
            fillDistancia6X.color = Color.yellow;
            verdex6.SetActive(true);

        }
        if (sliderDistancia6X.value > 0.005)
        {
            fillDistancia6X.color = Color.red;
            verdex6.SetActive(true);
            amarillox6.SetActive(true);
        }
    }
    public void sliderDistancia1Ymet()
    {
        string formatoY1 = sliderDistancia1Y.value.ToString("0.0");
        NUMY1.text = formatoY1.Substring(0, formatoY1.Length - 1);

        if (sliderDistancia1Y.value <= 0)
        {
            fillDistancia1Y.color = Color.green;
        }
        if (sliderDistancia1Y.value > 0 && sliderDistancia1Y.value <= 5)
        {
            fillDistancia1Y.color = Color.yellow;
            verdeY1.SetActive(true);

        }
        if (sliderDistancia1Y.value > 5)
        {
            fillDistancia1Y.color = Color.red;
            amarilloY1.SetActive(true);
            verdeY1.SetActive(true);
        }
    }
    public void sliderDistancia2Ymet()
    {
        string formatoY2 = sliderDistancia2Y.value.ToString("0.0");
        NUMY2.text = formatoY2.Substring(0, formatoY2.Length - 1);

        if (sliderDistancia2Y.value <= 0)
        {
            fillDistancia2Y.color = Color.green;
           
        }
        if (sliderDistancia2Y.value > 0 && sliderDistancia2Y.value <= 5)
        {
            fillDistancia2Y.color = Color.yellow;
            verdeY2.SetActive(true);



        }
        if (sliderDistancia2Y.value > 5)
        {
            fillDistancia2Y.color = Color.red;
            amarilloY2.SetActive(true);
            verdeY2.SetActive(true);

        }
    }
    public void sliderDistancia3Ymet()
    {
        string formatoY3 = sliderDistancia3Y.value.ToString("0.0");
        NUMY3.text = formatoY3.Substring(0, formatoY3.Length - 1);

        if (sliderDistancia3Y.value <= 0)
        {
            fillDistancia3Y.color = Color.green;
        }
        if (sliderDistancia3Y.value > 0 && sliderDistancia3Y.value <= 5)
        {
            fillDistancia3Y.color = Color.yellow;
            verdeY3.SetActive(true);

        }
        if (sliderDistancia3Y.value > 5)
        {
            fillDistancia3Y.color = Color.red;
            amarilloY3.SetActive(true);
            verdeY3.SetActive(true);
        }
    }
    public void sliderDistancia4Ymet()
    {
        string formatoY4 = sliderDistancia4Y.value.ToString("0.0");
        NUMY4.text = formatoY4.Substring(0, formatoY4.Length - 1);
        if (sliderDistancia4Y.value <= 0)
        {
            fillDistancia4Y.color = Color.green;
        }
        if (sliderDistancia4Y.value > 0 && sliderDistancia4Y.value <= 5)
        {
            fillDistancia4Y.color = Color.yellow;
            verdeY4.SetActive(true);

        }
        if (sliderDistancia4Y.value > 5)
        {
            fillDistancia4Y.color = Color.red;
            amarilloY4.SetActive(true);
            verdeY4.SetActive(true);
        }
    }
    public void sliderDistancia5Ymet()
    {
        string formatoY5 = sliderDistancia5Y.value.ToString("0.0");
        NUMY5.text = formatoY5.Substring(0, formatoY5.Length - 1);

        if (sliderDistancia5Y.value <= 0)
        {
            fillDistancia5Y.color = Color.green;
        }
        if (sliderDistancia5Y.value > 0 && sliderDistancia5Y.value <= 5)
        {
            fillDistancia5Y.color = Color.yellow;
            verdeY5.SetActive(true);

        }
        if (sliderDistancia5Y.value > 5)
        {
            fillDistancia5Y.color = Color.red;
            amarilloY5.SetActive(true);
            verdeY5.SetActive(true);
        }
    }
    public void sliderDistancia6Ymet()
    {
        string formatoY6 = sliderDistancia6Y.value.ToString("0.0");
        NUMY6.text = formatoY6.Substring(0, formatoY6.Length - 1);
        if (sliderDistancia6Y.value <= 0)
        {
            fillDistancia6Y.color = Color.green;
        }
        if (sliderDistancia6Y.value > 0 && sliderDistancia6Y.value <= 5)
        {
            fillDistancia6Y.color = Color.yellow;
            verdeY6.SetActive(true);

        }
        if (sliderDistancia6Y.value > 5)
        {
            fillDistancia6Y.color = Color.red;
            amarilloY6.SetActive(true);
            verdeY6.SetActive(true);
        }
    }
    public void sliderDistancia7Ymet()
    {
        string formatoY7 = sliderDistancia6Y.value.ToString("0.0");
        NUMY7.text = formatoY7.Substring(0, formatoY7.Length - 1);
        if (sliderDistancia7Y.value <= 0)
        {
            fillDistancia7Y.color = Color.green;
        }
        if (sliderDistancia7Y.value > 0 && sliderDistancia7Y.value <= 5)
        {
            fillDistancia7Y.color = Color.yellow;
            verdeY7.SetActive(true);

        }
        if (sliderDistancia7Y.value > 5)
        {
            fillDistancia7Y.color = Color.red;
            amarilloY7.SetActive(true);
            verdeY7.SetActive(true);
        }
    }
    public void sliderDistancia8Ymet()
    {
        string formatoY8 = sliderDistancia8Y.value.ToString("0.0");
        NUMY8.text = formatoY8.Substring(0, formatoY8.Length - 1);
        if (sliderDistancia8Y.value <= 0)
        {
            fillDistancia8Y.color = Color.green;
        }
        if (sliderDistancia8Y.value > 0 && sliderDistancia8Y.value <= 5)
        {
            fillDistancia8Y.color = Color.yellow;
            verdeY8.SetActive(true);

        }
        if (sliderDistancia8Y.value > 5)
        {
            fillDistancia8Y.color = Color.red;
            amarilloY8.SetActive(true);
            verdeY8.SetActive(true);
        }
    }
    public void sliderDistancia9Ymet()
    {
        string formatoY9 = sliderDistancia9Y.value.ToString("0.0");
        NUMY9.text = formatoY9.Substring(0, formatoY9.Length - 1);
        if (sliderDistancia9Y.value <= 0)
        {
            fillDistancia9Y.color = Color.green;
        }
        if (sliderDistancia9Y.value > 0 && sliderDistancia9Y.value <= 5)
        {
            fillDistancia9Y.color = Color.yellow;
            verdeY9.SetActive(true);

        }
        if (sliderDistancia9Y.value > 5)
        {
            fillDistancia9Y.color = Color.red;
            amarilloY9.SetActive(true);
            verdeY9.SetActive(true);
        }
    }
    public void sliderDistancia10Ymet()
    {
        string formatoY10 = sliderDistancia10Y.value.ToString("0.0");
        NUMY10.text = formatoY10.Substring(0, formatoY10.Length - 1);
        if (sliderDistancia10Y.value <= 0)
        {
            fillDistancia10Y.color = Color.green;
        }
        if (sliderDistancia10Y.value > 0 && sliderDistancia10Y.value <= 5)
        {
            fillDistancia10Y.color = Color.yellow;
            verdeY10.SetActive(true);

        }
        if (sliderDistancia10Y.value > 5)
        {
            fillDistancia10Y.color = Color.red;
            amarilloY10.SetActive(true);
            verdeY10.SetActive(true);
        }
    }
    public void sliderDistancia11Ymet()
    {
        string formatoY11 = sliderDistancia11Y.value.ToString("0.0");
        NUMY11.text = formatoY11.Substring(0, formatoY11.Length - 1);
        if (sliderDistancia11Y.value <= 0)
        {
            fillDistancia11Y.color = Color.green;
        }
        if (sliderDistancia11Y.value > 0 && sliderDistancia11Y.value <= 5)
        {
            fillDistancia11Y.color = Color.yellow;
            verdeY11.SetActive(true);

        }
        if (sliderDistancia11Y.value > 5)
        {
            fillDistancia11Y.color = Color.red;
            amarilloY11.SetActive(true);
            verdeY11.SetActive(true);
        }
    }
    public void sliderDistancia12Ymet()
    {
        string formatoY12 = sliderDistancia12Y.value.ToString("0.0");
        NUMY12.text = formatoY12.Substring(0, formatoY12.Length - 1);
        if (sliderDistancia12Y.value <= 0)
        {
            fillDistancia12Y.color = Color.green;
        }
        if (sliderDistancia12Y.value > 0 && sliderDistancia12Y.value <= 5)
        {
            fillDistancia12Y.color = Color.yellow;
            verdeY12.SetActive(true);

        }
        if (sliderDistancia12Y.value > 5)
        {
            fillDistancia12Y.color = Color.red;
            amarilloY12.SetActive(true);
            verdeY12.SetActive(true);
        }
    }
    public void sliderDistanciaMediaXmet()
    {
        string formatoDH = (sliderDistanciaMediaX.value * 1000).ToString("0.00");
        NUMDH.text = formatoDH.Substring(0, formatoDH.Length - 1) + "mm";

        if (sliderDistanciaMediaX.value <= 0.0025)
        {
            fillDistanciaMediaX.color = Color.green;
        }
        if (sliderDistanciaMediaX.value > 0.0025 && sliderDistanciaMediaX.value <= 0.005)
        {
            fillDistanciaMediaX.color = Color.yellow;
            verdeDH.SetActive(true);

        }
        if (sliderDistanciaMediaX.value > 0.005)
        {
            fillDistanciaMediaX.color = Color.red;
            verdeDH.SetActive(true);
            amarilloDH.SetActive(true);
        }
    }
     public void sliderDistanciaMediaYmet()
     {
         string formatoDV = sliderDistanciaMediaY.value.ToString("0.0");
         NUMDV.text = formatoDV.Substring(0, formatoDV.Length - 1);
         if (sliderDistanciaMediaY.value <= 0)
         {
             fillDistanciaMediaY.color = Color.green;
         }
         if (sliderDistanciaMediaY.value > 2 && sliderDistanciaMediaY.value <= 5)
         {
             fillDistanciaMediaY.color = Color.yellow;
             verdeDV.SetActive(true);
         }
         if (sliderDistanciaMediaY.value > 5)
         {
             fillDistanciaMediaY.color = Color.red;
             verdeDV.SetActive(true);
             amarilloDV.SetActive(true);
         }
     }
    public void cambioColorTiempoMedio()
    {
        string formatoTM = sliderTiempoMedio.value.ToString("0.0");
        NUMTM.text = formatoTM.Substring(0, formatoTM.Length - 1) + "s";
        if (sliderTiempoMedio.value <= 0)
        {
            fillTiempoMedio.color = Color.green;
        }
        if (sliderTiempoMedio.value > 3000 && sliderTiempoMedio.value <= 3000)
        {
            fillTiempoMedio.color = Color.yellow;
            verdetTM.SetActive(true);
        }
        if (sliderTiempoMedio.value > 3000)
        {
            fillTiempoMedio.color = Color.red;
            verdetTM.SetActive(true);
            amarilloTM.SetActive(true);
        }
    }
    public void sliderBiselDegree1()
    {
        string formatoY13 = sliderTiempo1.value.ToString("0.0");
        NUMT1.text = formatoY13.Substring(0, formatoY13.Length - 1);
        if (sliderTiempo1.value <= 15)
        {
            fillSliderTiempo1.color = Color.green;
        }
        if (sliderTiempo1.value > 15 && sliderTiempo1.value <= 45)
        {
            fillSliderTiempo1.color = Color.yellow;
            verdet1.SetActive(true);

        }
        if (sliderTiempo1.value > 45)
        {
            fillSliderTiempo1.color = Color.red;
            amarillot1.SetActive(true);
            verdet1.SetActive(true);
        }
    }
    public void sliderBiselDegree2()
    {
        string formatoY14 = sliderTiempo2.value.ToString("0.0");
        NUMT2.text = formatoY14.Substring(0, formatoY14.Length - 1);
        if (sliderTiempo2.value <= 15)
        {
            fillSliderTiempo2.color = Color.green;
        }
        if (sliderTiempo2.value > 15 && sliderTiempo2.value <= 45)
        {
            fillSliderTiempo2.color = Color.yellow;
            verdet2.SetActive(true);

        }
        if (sliderTiempo2.value > 45)
        {
            fillSliderTiempo2.color = Color.red;
            amarillot2.SetActive(true);
            verdet2.SetActive(true);
        }
    }
    public void sliderBiselDegree3()
    {
        string formatoY14 = sliderTiempo3.value.ToString("0.0");
        NUMT3.text = formatoY14.Substring(0, formatoY14.Length - 1);
        if (sliderTiempo3.value <= 15)
        {
            fillSliderTiempo3.color = Color.green;
        }
        if (sliderTiempo3.value > 15 && sliderTiempo3.value <= 45)
        {
            fillSliderTiempo3.color = Color.yellow;
            verdet3.SetActive(true);

        }
        if (sliderTiempo3.value > 45)
        {
            fillSliderTiempo3.color = Color.red;
            amarillot3.SetActive(true);
            verdet3.SetActive(true);
        }
    }
    public void sliderBiselDegree4()
    {
        string formatoY15 = sliderTiempo1.value.ToString("0.0");
        NUMT4.text = formatoY15.Substring(0, formatoY15.Length - 1);
        if (sliderTiempo4.value <= 15)
        {
            fillSliderTiempo4.color = Color.green;
        }
        if (sliderTiempo4.value > 15 && sliderTiempo4.value <= 45)
        {
            fillSliderTiempo4.color = Color.yellow;
            verdet4.SetActive(true);

        }
        if (sliderTiempo4.value > 45)
        {
            fillSliderTiempo4.color = Color.red;
            amarillot4.SetActive(true);
            verdet4.SetActive(true);
        }
    }
    public void sliderBiselDegree5()
    {
        string formatoY16 = sliderTiempo5.value.ToString("0.0");
        NUMT5.text = formatoY16.Substring(0, formatoY16.Length - 1);
        if (sliderTiempo5.value <= 15)
        {
            fillSliderTiempo5.color = Color.green;
        }
        if (sliderTiempo5.value > 15 && sliderTiempo5.value <= 45)
        {
            fillSliderTiempo5.color = Color.yellow;
            verdet5.SetActive(true);

        }
        if (sliderTiempo5.value > 45)
        {
            fillSliderTiempo5.color = Color.red;
            amarillot5.SetActive(true);
            verdet5.SetActive(true);
        }
    }
    public void sliderBiselDegree6()
    {
        string formatoY17 = sliderTiempo6.value.ToString("0.0");
        NUMT6.text = formatoY17.Substring(0, formatoY17.Length - 1);
        if (sliderTiempo6.value <= 15)
        {
            fillSliderTiempo6.color = Color.green;
        }
        if (sliderTiempo6.value > 15 && sliderTiempo6.value <= 45)
        {
            fillSliderTiempo6.color = Color.yellow;
            verdet6.SetActive(true);

        }
        if (sliderTiempo6.value > 45)
        {
            fillSliderTiempo6.color = Color.red;
            amarillot6.SetActive(true);
            verdet6.SetActive(true);
        }
    }
    public void cambioColorTurns()
    {
        string formatoTM1 = sliderTiempoMedio.value.ToString("0.0");
        NUMTM.text = formatoTM1.Substring(0, formatoTM1.Length - 1);
        if (sliderTiempoMedio.value <= 50)
        {
            fillTiempoMedio.color = Color.green;
        }
        if (sliderTiempoMedio.value > 50 && sliderTiempoMedio.value <= 150)
        {
            fillTiempoMedio.color = Color.yellow;
            verdetTM.SetActive(true);
        }
        if (sliderTiempoMedio.value > 150)
        {
            fillTiempoMedio.color = Color.red;
            verdetTM.SetActive(true);
            amarilloTM.SetActive(true);
        }
    }
    public void cambioColorAng()
    {
        string formatoTM2 = sliderAcumAng.value.ToString("0.0");
        NUMTM2.text = formatoTM2.Substring(0, formatoTM2.Length - 1);
        
    }
    public void sliderColorPos()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox10 = (sliderAcumPos.value).ToString("0.000");
        NUMTM2.text = formatox10.Substring(0, formatox10.Length - 1) + "m";
    }
}
