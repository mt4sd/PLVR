using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class SaveOptions : MonoBehaviour
{
    public TMP_InputField nombreDeCarpeta;
    public string directorio;
    public string rutaFinal;
    public string nombreArchivo;
    public TMP_Dropdown opcionAgujaDropdown;
    public TMP_Dropdown opcionPosicionDropdown;
    // Start is called before the first frame update
    void Start()
    {
        directorio = "C:/Users/Simulación/Desktop/PLVR/USUARIO";
        nombreArchivo = "OptionsSelected";
        

    }

    // Update is called once per frame
public void saveOptions()
    {
        int opcionAguja = opcionAgujaDropdown.value;
        int opcionPosicion = opcionPosicionDropdown.value;
        string folderName = nombreDeCarpeta.text;
        directorio = directorio + "/" + folderName;
        if (!Directory.Exists(directorio))
        {
            Directory.CreateDirectory(directorio);
        }
        string rutaArchivo = Path.Combine(directorio, nombreArchivo);
        string contenidoArchivo = "La opcion de la aguja fue la: " + opcionAguja + "\n";
        contenidoArchivo += "La opcion de la posicion del paciente fue: " + opcionPosicion;
        File.WriteAllText(rutaArchivo, contenidoArchivo);
    }
}
