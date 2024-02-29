using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;
using System;

public class ErrorController2 : MonoBehaviour
{
    public BS2Controller bS2Controller;
    public float patientPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator positionCehcker()
    {
        yield return new WaitForSeconds(2);
        patientPosition = BS2Controller.instancia.patient;
        if (patientPosition == 0)
        {
           // seatedPosition();
        }
    }

    
}
