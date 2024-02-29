using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;

public class CambiarColorSlider : MonoBehaviour
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
        string formatot1 =sliderTiempo1.value.ToString("0.0");
        NUMT1.text=formatot1.Substring(0, formatot1.Length - 1)+"s";
        
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
        if (sliderTiempo4.value > 3000 && sliderTiempo4.value <= 3005)
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
            verdet6.SetActive (true);
            amarillot6.SetActive(true);
        }
    }
    public void sliderDistancia1Xmet()
    {
        //sliderDistancia1.value =Mathf.Abs( ControladorDianas.posX1 - ControladorDianas.diana1objeto.transform.position.x);
        //slidervalueprueba = sliderDistancia1.value;
        //sliderDistancia1.value = ControladorDianas.DifX1;
        string formatox1 = (sliderDistancia1X.value * 1000).ToString("0.00");
        NUMX1.text = formatox1.Substring(0, formatox1.Length - 1)+"mm";
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
    /*public void sliderDistancia1Ymet()
    {
        string formatoY1 = (sliderDistancia1Y.value * 1000).ToString("0.00");
        NUMY1.text = formatoY1.Substring(0, formatoY1.Length - 1) + "mm";

        if (sliderDistancia1Y.value <= 0.005)
        {
            fillDistancia1Y.color = Color.green;
        }
        if (sliderDistancia1Y.value > 0.005 && sliderDistancia1Y.value <= 0.01)
        {
            fillDistancia1Y.color = Color.yellow;
            verdeY1.SetActive(true);

        }
        if (sliderDistancia1Y.value > 0.01)
        {
            fillDistancia1Y.color = Color.red;
            amarilloY1.SetActive(true);
            verdeY1.SetActive(true);
        }
    }
    public void sliderDistancia2Ymet()
    {
        string formatoY2 = (sliderDistancia2Y.value * 1000).ToString("0.00");
        NUMY2.text = formatoY2.Substring(0, formatoY2.Length - 1) + "mm";

        if (sliderDistancia2Y.value <= 0.005)
        {
            fillDistancia2Y.color = Color.green;
           
        }
        if (sliderDistancia2Y.value > 0.005 && sliderDistancia2Y.value <= 0.01)
        {
            fillDistancia2Y.color = Color.yellow;
            verdeY2.SetActive(true);



        }
        if (sliderDistancia2Y.value > 0.01)
        {
            fillDistancia2Y.color = Color.red;
            amarilloY2.SetActive(true);
            verdeY2.SetActive(true);

        }
    }
    public void sliderDistancia3Ymet()
    {
        string formatoY3 = (sliderDistancia3Y.value * 1000).ToString("0.00");
        NUMY3.text = formatoY3.Substring(0, formatoY3.Length - 1) + "mm";

        if (sliderDistancia3Y.value <= 0.005)
        {
            fillDistancia3Y.color = Color.green;
        }
        if (sliderDistancia3Y.value > 0.005 && sliderDistancia3Y.value <= 0.01)
        {
            fillDistancia3Y.color = Color.yellow;
            verdeY3.SetActive(true);

        }
        if (sliderDistancia3Y.value > 0.01)
        {
            fillDistancia3Y.color = Color.red;
            amarilloY3.SetActive(true);
            verdeY3.SetActive(true);
        }
    }
    public void sliderDistancia4Ymet()
    {
        string formatoY4 = (sliderDistancia4Y.value * 1000).ToString("0.00");
        NUMY4.text = formatoY4.Substring(0, formatoY4.Length - 1) + "mm";
        if (sliderDistancia4Y.value <= 0.005)
        {
            fillDistancia4Y.color = Color.green;
        }
        if (sliderDistancia4Y.value > 0.005 && sliderDistancia4Y.value <= 0.01)
        {
            fillDistancia4Y.color = Color.yellow;
            verdeY4.SetActive(true);

        }
        if (sliderDistancia4Y.value > 0.01)
        {
            fillDistancia4Y.color = Color.red;
            amarilloY4.SetActive(true);
            verdeY4.SetActive(true);
        }
    }
    public void sliderDistancia5Ymet()
    {
        string formatoY5 = (sliderDistancia5Y.value * 1000).ToString("0.00");
        NUMY5.text = formatoY5.Substring(0, formatoY5.Length - 1) + "mm";

        if (sliderDistancia5Y.value <= 0.005)
        {
            fillDistancia5Y.color = Color.green;
        }
        if (sliderDistancia5Y.value > 0.005 && sliderDistancia5Y.value <= 0.01)
        {
            fillDistancia5Y.color = Color.yellow;
            verdeY5.SetActive(true);

        }
        if (sliderDistancia5Y.value > 0.01)
        {
            fillDistancia5Y.color = Color.red;
            amarilloY5.SetActive(true);
            verdeY5.SetActive(true);
        }
    }
    public void sliderDistancia6Ymet()
    {
        string formatoY6 = (sliderDistancia6Y.value * 1000).ToString("0.00");
        NUMY6.text = formatoY6.Substring(0, formatoY6.Length - 1) + "mm";
        if (sliderDistancia6Y.value <= 0.005)
        {
            fillDistancia6Y.color = Color.green;
        }
        if (sliderDistancia6Y.value > 0.005 && sliderDistancia6Y.value <= 0.01)
        {
            fillDistancia6Y.color = Color.yellow;
            verdeY6.SetActive(true);

        }
        if (sliderDistancia6Y.value > 0.01)
        {
            fillDistancia6Y.color = Color.red;
            amarilloY6.SetActive(true);
            verdeY6.SetActive(true);
        }
    }*/
    public void sliderDistanciaMediaXmet()
    {
        string formatoDH = (sliderDistanciaMediaX.value*1000).ToString("0.00");
        NUMDH.text = formatoDH.Substring(0, formatoDH.Length - 1) + "mm";

        if (sliderDistanciaMediaX.value <= 0.0025)
        {
            fillDistanciaMediaX.color = Color.green;
        }
        if (sliderDistanciaMediaX.value > 0.0025 && sliderDistanciaMediaX.value <= 0.0005)
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
   /* public void sliderDistanciaMediaYmet()
    {
        string formatoDV = (sliderDistanciaMediaY.value * 1000).ToString("0.00");
        NUMDV.text = formatoDV.Substring(0, formatoDV.Length - 1) + "mm";
        if (sliderDistanciaMediaY.value <= 0.005)
        {
            fillDistanciaMediaY.color = Color.green;
        }
        if (sliderDistanciaMediaY.value > 0.005 && sliderDistanciaMediaY.value <= 0.01)
        {
            fillDistanciaMediaY.color = Color.yellow;
            verdeDV.SetActive(true);
        }
        if (sliderDistanciaMediaY.value > 0.01)
        {
            fillDistanciaMediaY.color = Color.red;
            verdeDV.SetActive(true);
            amarilloDV.SetActive(true);
        }
    }*/
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
}
