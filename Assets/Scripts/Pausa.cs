using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
using UnityEngine.Animations;


public class Pausa : MonoBehaviour
{
    private bool isPaused = false;
    //public Transform collider;
    public GameObject esferaoscura;
    public Transform visualMesh;
    public Transform collider;
    public GameObject stageSentado;
    public GameObject stageAcostado;
    public ScenesInformation scenesInformation;
    public int readyCheck;
    public float timePause;
    public float tiempoRetraso;
    public GameObject videoInstruccion;
    public HapticPlugin hapticplugin;
    public float position;

    public MeshRenderer meshHD1;
    public MeshRenderer meshHD2;
    public MeshRenderer meshHD3;
    public MeshRenderer meshHD4;
    public MeshRenderer meshHD5;
    public MeshRenderer meshHD6;
    public MeshRenderer meshHD7;
    public MeshRenderer meshHD8;
    public MeshRenderer meshHD9;
    public MeshRenderer meshAguja;
    public MeshRenderer meshMano1;
    public MeshRenderer meshMano2;
    public MeshRenderer meshMano3;
    
    public GameObject baseReposo;
    public bool readyExercise3;
    public float patient;
    public int arrowsPressed;

    public GameObject ins1;
    public GameObject ins2;
    public GameObject ins3;
    public GameObject ins4;
    public GameObject ins1VR;
    public GameObject ins2VR;
    public GameObject ins3VR;
    public GameObject ins4VR;

    public GameObject buttons;
    public GameObject buttonsVR;

    void Start() {
        //Pause();
        arrowsPressed = 0;
        readyCheck = 0;
        readyExercise3 = false;
        patient = ScenesInformation.instancia.opPatientPosition;
        //ScenesInformation.instancia.videoRetrocesoOn();
        //videoInstruccion.SetActive(true);
        timePause += Time.deltaTime;
        //habrá que poner la animación de alejar el háptico
    }
    void Update()
    {
        timePause += Time.deltaTime;

        position = hapticplugin.CurrentPosition.z;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ControlarPause();
        }

        if(position>=90 && readyCheck == 0 && arrowsPressed==4)
        {
            ScenesInformation.instancia.esferaTransitions.SetActive(false);
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            readyExercise3 = true;
            Debug.Log("Se inició la transicion");
            //stage.SetActive(true);
            tiempoRetraso = timePause;
            StartCoroutine(waitingForStage());
            readyCheck = 1;
        }
    }
    public void ControlarPause()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            Pause();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
        
    }

    public void ResumeGame()
    {
        Debug.Log("Pulsaste");
        Time.timeScale = 1;
        isPaused = false;
        //StartCoroutine(borrarEsfera());
        ScenesInformation.instancia.videoRetrocesoOff();

    }

    IEnumerator borrarEsfera()
    {
        yield return new WaitForSeconds(2);
        esferaoscura.SetActive(false);
    }

    /*public void exitToMenu()
    {
        Debug.Log("Se pulsó el botón");
        //if (collider.localPosition.z >= 0.12)
       // {
            ScenesInformation.instancia.esferaTransitions.SetActive(true);
            StartCoroutine(waitingForStage());
            //SceneManager.LoadScene(1);
        //}
    }*/
    public void resumeGameHapticBotton()
{
    ResumeGame();
}
   /*IEnumerator waitingForExit() //cambiarlo por bola que al tocarla te vuelve al menu inicial
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
        yield return new WaitForSeconds(3);
            //ScenesInformation.instancia.esferaTransitions.SetActive(false);

    }*/
    IEnumerator waitingForStage()
    {
        Debug.Log("Entré al waiting");
        yield return new WaitForSeconds(2);
        if (patient == 0)
        {
            stageSentado.SetActive(true);
        }
        if (patient == 1)
        {
            stageAcostado.SetActive(true);
        }
        baseReposo.SetActive(false);
        meshHD1.enabled = false;
        meshHD2.enabled = false;
        meshHD3.enabled = false;
        meshHD4.enabled = false;
        meshHD5.enabled = false;
        meshHD6.enabled = false;
        meshHD7.enabled = false;
        meshHD8.enabled = false;
        meshHD9.enabled= false;
        meshAguja.enabled = true;
        meshMano1.enabled = true;
        meshMano2.enabled = true;
        meshMano3.enabled = true;


        videoInstruccion.SetActive(false);
        //ScenesInformation.instancia.videoRetroceso.SetActive(false);

        yield return new WaitForSeconds(3);
        ScenesInformation.instancia.esferaTransitions.SetActive(false);

    }

    public void arrowPressed()
    {
        arrowsPressed++;
        switch (arrowsPressed)
        {
            case 1:
                ins1.SetActive(false);
                ins1VR.SetActive(false);
                ins2.SetActive(true);
                ins2VR.SetActive(true);
                break;
            case 2:
                ins2.SetActive(false);
                ins2VR.SetActive(false);
                ins3.SetActive(true);
                ins3VR.SetActive(true);
                break ;
            case 3:
                ins3.SetActive(false);
                ins3VR.SetActive(false);
                ins4.SetActive(true);
                ins4VR.SetActive(true);
                break;
            case 4:
                ins4.SetActive(false);
                ins4VR.SetActive(false);
                buttons.SetActive(false);
                buttonsVR.SetActive(false);
                videoInstruccion.SetActive(true);
                break;
        }
    }

    public void skip()
    {
        ins1.SetActive(false);
        ins1VR.SetActive(false);
        ins2.SetActive(false);
        ins2VR.SetActive(false);
        ins3.SetActive(false);
        ins3VR.SetActive(false);
        ins4.SetActive(false);
        ins4VR.SetActive(false);
        buttons.SetActive(false);
        buttonsVR.SetActive(false);
        arrowsPressed = 4;
        videoInstruccion.SetActive(true);
    }
    public void skipFin()
    {
        buttons.SetActive(false);
        ins1.SetActive(false);
        arrowsPressed = 4;
    }



}

