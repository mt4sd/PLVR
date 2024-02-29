//MIT License
//Copyright (c) 2023 DA LAB (https://www.youtube.com/@DA-LAB)
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SFB;
using System;
using TMPro;
public class SaveFile : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public BS2Controller controller2;
    public BS3C controller3;
    public BS1Controller controller;
    public GameObject panelresults2;


#if UNITY_WEBGL && !UNITY_EDITOR
    // WebGL
    [DllImport("__Internal")]
    private static extern void DownloadFile(string gameObjectName, string methodName, string filename, byte[] byteArray, int byteArraySize);

    public void OnClickSave() {
        var bytes = Encoding.UTF8.GetBytes(textMeshPro.text);
        DownloadFile(gameObject.name, "OnFileDownload", "model.obj", bytes, bytes.Length);
    }

    // Called from browser
    public void OnFileDownload() { }
#else

    // Standalone platforms & editor
    public void OnClickSave()
    {
        textMeshPro.text = "Target 1 distance: " + controller.distanciaD1.ToString() + " m   :    Target 1 time: " + controller.tiempobola1.ToString() + " s \n Target 2 distance: " + controller.distanciaD2.ToString() + " m   :    Target 2 time: " + controller.tiempobola2.ToString() + " s \n Target 3 distance: " + controller.distanciaD3.ToString() + " m   :    Target 3 time: " + controller.tiempobola3.ToString() + " s \n Target 4 distance: " + controller.distanciaD4.ToString() + " m   :    Target 4 time: " + controller.tiempobola4.ToString() + " s \n Target 5 distance: " + controller.distanciaD5.ToString() + " m   :    Target 5 time: " + controller.tiempobola5.ToString() + " s \n Target 6 distance: " + controller.distanciaD6.ToString() + " m   :    Target 6 time: " + controller.tiempobola6.ToString() + " s \n Average Distance: " + controller.distanciaMediaX.ToString() + "m   :   Average time: " + controller.tiempoMedio.ToString() + " s   ;   Total time: " + controller.tiempoTotal.ToString() + " s";
        string path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "results", "txt");

        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, textMeshPro.text);
        }
    }
    public void OnClickSave2()
    {
        textMeshPro.text = "Target   :   Accuracy(m)   :   Movement deviations   :   Angles deviations   :   Time(s)\n" + "1   :   " + controller2.distanciaD1.ToString() + "   :   " + controller2.devOn1.ToString() + "   :   " + controller2.devAng1.ToString() + "   :   " + controller2.tiempobola1.ToString() + "\n" + "2   :   " + controller2.distanciaD2.ToString() + "   :   " + controller2.devOn2.ToString() + "   :   " + controller2.devAng2.ToString() + "   :   " + controller2.tiempobola2.ToString() + "\n" + "3   :   " + controller2.distanciaD3.ToString() + "   :   " + controller2.devOn3.ToString() + "   :   " + controller2.devAng3.ToString() + "   :   " + controller2.tiempobola3.ToString() + "\n" + "4   :   " + controller2.distanciaD4.ToString() + "   :   " + controller2.devOn4.ToString() + "   :   " + controller2.devAng4.ToString() + "   :   " + controller2.tiempobola4.ToString() + "\n" + "5   :   " + controller2.distanciaD5.ToString() + "   :   " + controller2.devOn5.ToString() + "   :   " + controller2.devAng5.ToString() + "   :   " + controller2.tiempobola5.ToString() + "\n" + "6   :   " + controller2.distanciaD6.ToString() + "   :   " + controller2.devOn6.ToString() + "   :   " + controller2.devAng6.ToString() + "   :   " + controller2.tiempobola6.ToString() + "\n Average accuracy (m): " + controller2.distanciaMediaX.ToString() + "   :   Total deviations: " + controller2.distanciaMediaY.ToString() + "   :   Average time(s): " + controller2.tiempoMedio.ToString() + "   :   Total time(s): " + controller2.tiempoTotal.ToString() + "   :   Sume of angle variations (degrees) :" + controller2.acumTotal.ToString(); ;
        string path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "results", "txt");
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, textMeshPro.text);
        }
    }

    public void OnClickSave3()
    {
        textMeshPro.text = "Target   :   Accuracy(m)   :   Movement deviations   :   Angles deviations   :   Bevel orientation deviation (degrees)\n" + "1   :   " + controller3.distanciaD1.ToString() + "   :   " + controller3.devOn1.ToString() + "   :   " + controller3.devAng1.ToString() + "   :   " + controller3.tiempobola1.ToString() + "\n" + "2   :   " + controller3.distanciaD2.ToString() + "   :   " + controller3.devOn2.ToString() + "   :   " + controller3.devAng2.ToString() + "   :   " + controller3.tiempobola2.ToString() + "\n" + "3   :   " + controller3.distanciaD3.ToString() + "   :   " + controller3.devOn3.ToString() + "   :   " + controller3.devAng3.ToString() + "   :   " + controller3.tiempobola3.ToString() + "\n" + "4   :   " + controller3.distanciaD4.ToString() + "   :   " + controller3.devOn4.ToString() + "   :   " + controller3.devAng4.ToString() + "   :   " + controller3.tiempobola4.ToString() + "\n" + "5   :   " + controller3.distanciaD5.ToString() + "   :   " + controller3.devOn5.ToString() + "   :   " + controller3.devAng5.ToString() + "   :   " + controller3.tiempobola5.ToString() + "\n" + "6   :   " + controller3.distanciaD6.ToString() + "   :   " + controller3.devOn6.ToString() + "   :   " + controller3.devAng6.ToString() + "   :   " + controller3.tiempobola6.ToString() + "\n Average accuracy (m): " + controller3.distanciaMediaX.ToString() + "   :   Total deviations: " + controller3.distanciaMediaY.ToString() + "   :   Total bevel variation (degrees): " + controller3.acumBevel.ToString() + "   :   Total time(s): " + controller3.tiempoTotal.ToString() + "   :   Sume of angle variations (degrees) :" + controller3.acumTotal.ToString()+"   :   Movements (m): "+controller3.acumpos.ToString();
        string path = StandaloneFileBrowser.SaveFilePanel("Save File", "", "results", "txt");
        if (!string.IsNullOrEmpty(path))
        {
            File.WriteAllText(path, textMeshPro.text);
        }
    }
#endif
    public void results2()
    {
        panelresults2.SetActive(true);
    }


}
