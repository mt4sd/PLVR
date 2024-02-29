using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public GameObject esferaTransicion; //esfera para inicar transición
    // Start is called before the first frame update
    public Animator FadeOut;
    public ScenesInformation sceneinformation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void volverMenu()
    {
        //ScenesInformation.instancia.esferaTransitions.SetActive(true);
        ScenesInformation.instancia.sceneSwitcherMenu(1);
        //esferaTransicion.SetActive(true);
        //FadeOut.SetBool("CambioEscena", true);
        //StartCoroutine(CambioEscena());
    }
    IEnumerator CambioEscena()
    {
        yield return new WaitForSeconds(2);
        {
            SceneManager.LoadScene("MenuVR");

        }
    }
}
