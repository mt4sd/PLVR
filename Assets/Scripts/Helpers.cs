using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers : MonoBehaviour
{
    public GameObject ayudaFlacoAcostado;
    public GameObject ayudaGordoAcostado;
    public GameObject ayudaFlacoTumbado;
    public GameObject ayudaGordoTumbado;
    public int estado;

    // Start is called before the first frame update
    void Start()
    {
        estado = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void helpActivation()
    {

        if (estado == 0)
        {
            ayudaFlacoAcostado.SetActive(true);
            ayudaGordoAcostado.SetActive(true);
            ayudaFlacoTumbado.SetActive(true);
            ayudaGordoTumbado.SetActive(true);
            estado = 1;
        }
        if (estado == 1)
        {
            ayudaFlacoAcostado.SetActive(false);
            ayudaGordoAcostado.SetActive(false);
            ayudaFlacoTumbado.SetActive(false);
            ayudaGordoTumbado.SetActive(false);
            estado = 0;
        }

    }

}
