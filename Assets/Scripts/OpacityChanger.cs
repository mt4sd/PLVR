using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;
using UnityEngine.Animations;

public class OpacityChanger : MonoBehaviour
{
    public Renderer man;
    public Renderer manAcostado;
    public Renderer staObsman;
    public Renderer staObsmanAcostado; 
    public Renderer obsman;
    public Renderer obsmanAcostado;
    public Material manOpaque;
    public Material manFade;
    public Material pielOpaque;
    public Material pielFade;
    public TMP_Dropdown opacityDrop;
    public GameObject opacityMenu;

    public TMP_Dropdown obeseDrop;

    public GameObject standardMan;
    public GameObject standardManAcostado;
    public GameObject standardObeseMan;
    public GameObject standardObeseManAcostado;
    public GameObject obeseMan;
    public GameObject obeseManAcostado;
    //public Transform planePiel;
    //public Transform planePielAcostado;
    //public Transform fatViscosityPosition;
    //public GameObject fatViscosity;
    public Vector3 originalPielPosition;
    public Vector3 originalPielPositionAcostado;

    public GameObject canvaVr;
    public GameObject canva;
    public GameObject button;


    // Start is called before the first frame update
    void Start()
    {
        //originalPielPosition = planePiel.localPosition;
        //originalPielPositionAcostado = planePielAcostado.localPosition;
    }

    // Update is called once per frame
    public void cambiarOpacity()
    {
        if (opacityDrop.value == 0)
        {
            man.material = manFade;
            manAcostado.material = manFade;
            //staObsman.material = pielFade;
            obsman.material = pielFade;
            //staObsmanAcostado.material = pielFade;
            obsmanAcostado.material = pielFade;
        }
        if (opacityDrop.value == 1)
        {
            man.material = manOpaque;
            manAcostado.material = manOpaque;
            //staObsman.material = pielOpaque;
            //staObsmanAcostado.material = pielOpaque;
            obsmanAcostado.material = pielOpaque;
            obsman.material = pielOpaque;


        }

    }

    public void openOpacityMenu()
    {
       opacityMenu.SetActive(true);
    }
    public void closeOpacityMenu()
    {
        opacityMenu.SetActive(false);

    }

    public void obeseModifier()
    {
        if(obeseDrop.value == 0)
        {
            if (ScenesInformation.instancia.opPatientPosition == 0)
            {
                standardMan.SetActive(true);
                //planePiel.position = originalPielPosition;

                //standardObeseMan.SetActive(false);
                obeseMan.SetActive(false);
                //fatViscosity.SetActive(false);
            }
            if (ScenesInformation.instancia.opPatientPosition == 1)
            {
                standardManAcostado.SetActive(true);
                //planePielAcostado.position = originalPielPositionAcostado;

                //standardObeseManAcostado.SetActive(false);
                obeseManAcostado.SetActive(false);
                //fatViscosity.SetActive(false);
            }
        }
        if (obeseDrop.value ==1)
        {
            if (ScenesInformation.instancia.opPatientPosition == 0)
            {
                //standardObeseMan.SetActive(true);
                //planePiel.localPosition = new Vector3(originalPielPosition.x, originalPielPosition.y+ 0.006f, originalPielPosition.z);

                standardMan.SetActive(false);
                obeseMan.SetActive(true);
                //fatViscosity.SetActive(true);
                //fatViscosityPosition.localPosition = new Vector3(0f, 0f, 0f);//tengo que comprobar mañana a ver cuál le vale 
            }
            if (ScenesInformation.instancia.opPatientPosition == 1)
            {
                //standardObeseManAcostado.SetActive(true);
                //planePielAcostado.localPosition = new Vector3(originalPielPositionAcostado.x, originalPielPositionAcostado.y + 0.006f, originalPielPositionAcostado.z);

                standardManAcostado.SetActive(false);
                obeseManAcostado.SetActive(true);
                //fatViscosity.SetActive(true);
                //fatViscosityPosition.localPosition = new Vector3(0f, 0f, 0f);//tengo que comprobar mañana a ver cuál le vale 
            }

        }
        
    }

}
