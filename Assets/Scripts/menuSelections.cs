using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System.Globalization;

public class menuSelections : MonoBehaviour
{
    //LAS REALES
    /*public GameObject textI1;
    public GameObject textI2;
    public GameObject textOPA;
    public GameObject textOPB;
    public GameObject textOPC;
    public GameObject textOP1;
    public GameObject textOP2;
    public GameObject imagenPM1;
    public GameObject imagenPM2;
    public GameObject imagenPM3;
    public GameObject imagenPA1;
    public GameObject imagenPA2;
    public GameObject dropdownPM;
    public GameObject dropdownPA;
    public GameObject textOPA1;
    public GameObject textOPA2;*/

    public GameObject instruccion2;
    public GameObject instruccion1;
    public GameObject instruccion1VR;
    public GameObject instruccion2VR;
    public GameObject instruccion3;
    public GameObject instruccion3VR;



    //LAS VR
    /*public GameObject textI1VR;
    public GameObject textI2VR;
    public GameObject textOPAVR;
    public GameObject textOPBVR;
    public GameObject textOPCVR;
    public GameObject textOP1VR;
    public GameObject textOP2VR;
    public GameObject imagenPM1VR;
    public GameObject imagenPM2VR;
    public GameObject imagenPM3VR;
    public GameObject imagenPA1VR;
    public GameObject imagenPA2VR;
    public GameObject dropdownPMVR;
    public GameObject dropdownPAVR;
    public GameObject textOPA1VR;
    public GameObject textOPA2VR;*/

    public ScenesInformation scenesInformation;

    public TMP_Dropdown scrolbarManoM;
    public TMP_Dropdown scrolbarPatientPositionM;
    public TMP_Dropdown scrolbarFAT;

    public int stepDone;

    public GameObject imagentele;
    public GameObject canvaSelections;





    // Start is called before the first frame update
    void Start()
    {
        stepDone = 0;
    }

    // Update is called once per frame

    public void seleccionarMenu()
    {
        switch (stepDone)
        {
            case 0:
                instruccion1.SetActive(false);
                instruccion1VR.SetActive(false);


                instruccion2.SetActive(true);
                instruccion2VR.SetActive(true);


                break;
            case 1:
                ScenesInformation.instancia.opMano = scrolbarManoM.value;
                ScenesInformation.instancia.opPatientPosition = scrolbarPatientPositionM.value;
                ScenesInformation.instancia.opFAT = scrolbarFAT.value;
                imagentele.SetActive(false);
                canvaSelections.SetActive(false);
                /*instruccion2.SetActive(false);
                instruccion2VR.SetActive(false);

                instruccion3.SetActive(true);
                instruccion3VR.SetActive(true);*/
                break;
            case 2:
                /*ScenesInformation.instancia.opMano = scrolbarManoM.value;
                ScenesInformation.instancia.opPatientPosition = scrolbarPatientPositionM.value;
                ScenesInformation.instancia.opFAT=scrolbarFAT.value;
                imagentele.SetActive(false);
                canvaSelections.SetActive(false);*/
                break;

        }

        stepDone++;
    }
    public void configurationOpener()
    {
        canvaSelections.SetActive(true);
    }
    public void configurationCloser()
    {
        canvaSelections.SetActive(false);
    }

}
