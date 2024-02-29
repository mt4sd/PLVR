using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pruebas : MonoBehaviour
{
    //public Slider sliderrojoPrefab;
    //public Image fillSlider;
    public Transform cubo;
    public Transform mando;
    public float velocidadRotacion = 1f;//velocidad rotation
    public Transform cubito;

    
    public float valorInfoSetUp;
    /*public float valueSlider;
    public Transform sliderUbi;*/
    // Start is called before the first frame update

    void Start()
    {
        cubito = ScenesInformation.instancia.marker;
        valorInfoSetUp = ScenesInformation.instancia.opMano;
        /*GameObject sliderGO = Instantiate(sliderrojoPrefab, sliderUbi); // Instanciar el Slider
        Slider slider = sliderGO.GetComponent<Slider>(); // Obtener el componente Slider

        slider.value = valueSlider;*/ // Establecer el valor inicial del Slider
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            reposicionarHaptico();
        }

        
    }
   /* public void cambioColor()
    {
        if (sliderrojoPrefab.value <= 20)
        {
            fillSlider.color = Color.red;
        }
        if (sliderrojoPrefab.value > 20 && sliderrojoPrefab.value<=60)
        {
            fillSlider.color = Color.yellow;
        }
        if (sliderrojoPrefab.value > 60)
        {
            fillSlider.color = Color.green;
        }
    }*/
    public void reposicionarHaptico()
    {
        Debug.Log("Holiiii");
        cubo.position = mando.position;
    }

}
