using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
using UnityEngine.Animations;

public class ColliderPosition : MonoBehaviour
{
    public float posx;
    public float posy;
    public float posz;

    public float posTx;
    public float posty;
    public float postz;
    //public Transform tipReference;
    public ScenesInformation scenesinformation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posx =transform.localPosition.x;
        posy = transform.localPosition.y;
        posz = transform.localPosition.z;

        /* = tipReference.localPosition.x;
        posty = tipReference.localPosition.y;
        postz = tipReference.localPosition.z;*/

        if (posx > 0.8 && posy < -0.26 && posz > 1.4)
        {
            exitToMenu();
        }
    }

    public void exitToMenu()
    {
        ScenesInformation.instancia.esferaTransitions.SetActive(true);
        StartCoroutine(cambioEscena(1));
    }
    IEnumerator cambioEscena(int scene)
    {
        yield return new WaitForSeconds(2);
        ScenesInformation.instancia.sphereActiva = true;
        SceneManager.LoadScene(scene);

    }
}
