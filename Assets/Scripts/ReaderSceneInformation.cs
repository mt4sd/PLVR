using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaderSceneInformation : MonoBehaviour
{
    public ScenesInformation scenesInformation;
    public Transform scene;
    public float mano;
    public float patient;
    
    public GameObject mano1;
    public GameObject mano2;
    public GameObject mano3;
    public GameObject stage;
    // Start is called before the first frame update
    void Start()
    {
        //scene.rotation = Quaternion.Euler(ScenesInformation.instancia.TargetRotation);
        
        scene.position = ScenesInformation.instancia.TargetPosition;
        scene.rotation = Quaternion.Euler(ScenesInformation.instancia.TargetRotation);

        mano = ScenesInformation.instancia.opMano;
        patient = ScenesInformation.instancia.opPatientPosition;
        if (mano == 0)
        {
            mano1.SetActive(true);
            mano2.SetActive(false);
            mano3.SetActive(false);
        }
        if (mano == 1)
        {
            mano1.SetActive(false);
            mano2.SetActive(true);
            mano3.SetActive(false);

        }
        if (mano == 2)
        {
            mano1.SetActive(false);
            mano2.SetActive(false);
            mano3.SetActive(true);
        }
        stage.SetActive(false);

        //scenesInformation=referencia.GetComponent<ScenesInformation>();
        //scene.position = scenesInformation.TargetPosition;
    }

}

// Update is called once per frame
