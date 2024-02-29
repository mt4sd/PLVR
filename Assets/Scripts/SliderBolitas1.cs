using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
public class SliderBolitas1 : MonoBehaviour
{
    public Slider sliderDHInicial;//es el del timepo total
    public Slider sliderDVInicial;
    public Slider sliderDHFinal;
    public Slider sliderDVFinal;
    public Slider sliderDH;
    public Slider sliderDV;
    public Slider sliderDistanciaH;
    public Slider sliderDistanciaV;
    public Slider sliderTiempo;
    public Image fillSliderDHInicial;
    public Image fillSliderDVInicial;
    public Image fillSliderDHFinal;
    public Image fillSliderDVFinal;
    public Image fillSliderDH;
    public Image fillSliderDV;
    public Image fillSliderDistanciaH;
    public Image fillSliderDistanciaV;
    public Image fillSliderTiempo;

    public ControladorRecta ControladorRecta;
    
    public GameObject verdex1;
    public GameObject amarillox1;
    public GameObject verdeY1;
    public GameObject amarilloY1;


    public GameObject verdex2;
    public GameObject amarillox2;
    public GameObject verdeY2;
    public GameObject amarilloY2;


    public GameObject verdex3;
    public GameObject amarillox3;


    public GameObject verdex4;
    public GameObject amarillox4;


    public GameObject verdex5;
    public GameObject amarillox5;


    public GameObject verdex6;
    public GameObject amarillox6;



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
    public TMP_InputField NUMTT;

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
    public void cambioColorTiempo()
    {
        string formatotT = sliderTiempo.value.ToString("0.0");
        NUMTT.text = formatotT.Substring(0, formatotT.Length - 1) + "s";
        if (sliderDHInicial.value <= 10)
        {
            fillSliderTiempo.color = Color.green;
        }
        if (sliderTiempo.value > 10 && sliderTiempo.value <= 18)
        {
            fillSliderTiempo.color = Color.yellow;
            verdetTT.SetActive(true);
        }
        if (sliderTiempo.value > 18)
        {
            fillSliderTiempo.color = Color.red;
            verdetTT.SetActive(true);
            amarilloTT.SetActive(true);
        }
    }
   
    public void colorsliderDHInicial()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox1 = (sliderDHInicial.value * 1000).ToString("0.00");
        NUMX1.text = formatox1.Substring(0, formatox1.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDHInicial.value <= 0.005)
        {
            fillSliderDHInicial.color = Color.green;
        }
        if (sliderDHInicial.value > 0.005 && sliderDHInicial.value <= 0.01)
        {
            fillSliderDHInicial.color = Color.yellow;
            verdex1.SetActive(true);

        }
        if (sliderDHInicial.value > 0.01)
        {
            fillSliderDHInicial.color = Color.red;
            verdex1.SetActive(true);
            amarillox1.SetActive(true);

        }
    }
    public void colorsliderDVInicial()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox2 = (sliderDVInicial.value * 1000).ToString("0.00");
        NUMX2.text = formatox2.Substring(0, formatox2.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDVInicial.value <= 0.005)
        {
            fillSliderDVInicial.color = Color.green;
        }
        if (sliderDVInicial.value > 0.005 && sliderDVInicial.value <= 0.01)
        {
            fillSliderDVInicial.color = Color.yellow;
            verdex2.SetActive(true);

        }
        if (sliderDVInicial.value > 0.01)
        {
            fillSliderDVInicial.color = Color.red;
            verdex2.SetActive(true);
            amarillox2.SetActive(true);

        }
    }
    public void colorsliderDHFinal()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox3 = (sliderDHFinal.value * 1000).ToString("0.00");
        NUMX3.text = formatox3.Substring(0, formatox3.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDHFinal.value <= 0.005)
        {
            fillSliderDHFinal.color = Color.green;
        }
        if (sliderDHFinal.value > 0.005 && sliderDHFinal.value <= 0.01)
        {
            fillSliderDHFinal.color = Color.yellow;
            verdex3.SetActive(true);

        }
        if (sliderDHFinal.value > 0.01)
        {
            fillSliderDHFinal.color = Color.red;
            verdex3.SetActive(true);
            amarillox3.SetActive(true);

        }
    }
    public void colorsliderDVFinal()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox4 = (sliderDVFinal.value * 1000).ToString("0.00");
        NUMX4.text = formatox4.Substring(0, formatox4.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDVFinal.value <= 0.005)
        {
            fillSliderDVFinal.color = Color.green;
        }
        if (sliderDVFinal.value > 0.005 && sliderDVFinal.value <= 0.01)
        {
            fillSliderDVFinal.color = Color.yellow;
            verdex4.SetActive(true);

        }
        if (sliderDVFinal.value > 0.01)
        {
            fillSliderDVFinal.color = Color.red;
            verdex4.SetActive(true);
            amarillox4.SetActive(true);

        }
    }
    public void colorsliderDistanciaH()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox5 = (sliderDistanciaH.value * 1000).ToString("0.00");
        NUMX5.text = formatox5.Substring(0, formatox5.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDistanciaH.value <= 0.005)
        {
            fillSliderDistanciaH.color = Color.green;
        }
        if (sliderDistanciaH.value > 0.005 && sliderDistanciaH.value <= 0.03)
        {
            fillSliderDistanciaH.color = Color.yellow;
            verdex5.SetActive(true);

        }
        if (sliderDistanciaH.value > 0.03)
        {
            fillSliderDistanciaH.color = Color.red;
            verdex5.SetActive(true);
            amarillox5.SetActive(true);

        }
    }
    public void colorsliderDistanciaV()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox6 = (sliderDistanciaV.value * 1000).ToString("0.00");
        NUMX6.text = formatox6.Substring(0, formatox6.Length - 1) + "mm";
        //(sliderDistancia1X.value*1000).ToString() + "mm"; cdsdsds v
        // Mathf.Floor(sliderDistancia1X.value * 1000;
        if (sliderDistanciaV.value <= 0.005)
        {
            fillSliderDistanciaV.color = Color.green;
        }
        if (sliderDistanciaV.value > 0.005 && sliderDistanciaV.value <= 0.03)
        {
            fillSliderDistanciaV.color = Color.yellow;
            verdex6.SetActive(true);

        }
        if (sliderDistanciaV.value > 0.03)
        {
            fillSliderDistanciaV.color = Color.red;
            verdex6.SetActive(true);
            amarillox6.SetActive(true);

        }
    }
    
    public void colorsliderDH()
    {
        string formatoY1 = sliderDH.value.ToString();
        NUMY1.text = formatoY1 + "";

        if (sliderDH.value <1)
        {
            fillSliderDH.color = Color.green;
        }
        if (sliderDH.value >=1 && sliderDH.value <= 3)
        {
            fillSliderDH.color = Color.yellow;
            verdeY1.SetActive(true);

        }
        if (sliderDH.value > 3)
        {
            fillSliderDH.color = Color.red;
            amarilloY1.SetActive(true);
            verdeY1.SetActive(true);
        }
    }

    public void colorsliderDV()
    {
        string formatoY2 = sliderDV.value.ToString();
        NUMY2.text = formatoY2 + "";

        if (sliderDV.value < 1)
        {
            fillSliderDV.color = Color.green;
        }
        if (sliderDV.value >= 1 && sliderDV.value <= 3)
        {
            fillSliderDV.color = Color.yellow;
            verdeY2.SetActive(true);

        }
        if (sliderDV.value > 3)
        {
            fillSliderDV.color = Color.red;
            amarilloY2.SetActive(true);
            verdeY2.SetActive(true);
        }
    }
    
}
