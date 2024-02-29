using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopInVR : MonoBehaviour
{
    public GameObject desktopMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
public void abrirDesktopMenu()
    {
        desktopMenu.SetActive(true);
    }

    public void cerrarDesktopMenu()
    {
        desktopMenu.SetActive(false);   
    }
}
