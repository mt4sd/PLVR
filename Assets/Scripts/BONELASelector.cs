using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BONELASelector : MonoBehaviour
{
    public HapticMaterial hapticMaterialToChange;
    public int numAleatorio;
    public int contador;
    public int elec1;
    public int elec2;
    public int elec3;
    public int elec4;
    public int elec5;
    public int elec6;
    public bool condicion;
    public GameObject plano;
    public Transform hapticCollider;
    // Start is called before the first frame update
    void Start()
    {
        System.Random aleatorio = new System.Random();
        numAleatorio = aleatorio.Next(1,100);
        contador = 0;
        condicion = true;
    }

    // Update is called once per frame
    void Update()
    { //Para detectar donde está el háptico hay que cambiar los 0 por los valores reales
        if((hapticCollider.localPosition.x<=-1.158&&hapticCollider.localPosition.x>=-1.53)&& (hapticCollider.localPosition.y <= 0.621 && hapticCollider.localPosition.y >= 0.246)&& (hapticCollider.localPosition.z <= 1.146 && hapticCollider.localPosition.z >= 0.765))
        {
            changeHMpop(0);
        }
        if ((hapticCollider.localPosition.x <= -1.158 && hapticCollider.localPosition.x >= -1.53) && (hapticCollider.localPosition.y <= -0.524 && hapticCollider.localPosition.y >= -0.17) && (hapticCollider.localPosition.z <= 0.765 && hapticCollider.localPosition.z >= -1.146))
        {
            changeHMpop(1);
        }
    }
    
    public void changeHMpop(int eleccion)
    {
        if (condicion == true)
        {
            contador++;
            System.Random aleatorio1 = new System.Random();
            plano.SetActive(false);

            if (eleccion == 0)
            {
                switch (contador)
                {
                    case 1:
                        elec1 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 2:
                        elec2 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 3:
                        elec3 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 4:
                        elec4 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 5:
                        elec5 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 6:
                        elec6 = 0;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                }
            }
            if (eleccion == 1)
            {
                switch (contador)
                {
                    case 1:
                        elec1 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 2:
                        elec2 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 3:
                        elec3 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 4:
                        elec4 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 5:
                        elec5 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                    case 6:
                        elec6 = 1;
                        numAleatorio = aleatorio1.Next(1, 100);
                        break;
                }
            }
            if (numAleatorio <= 50)
            {
                hapticMaterialToChange.hPopthAbs = (float)1.2;
            }
            if (numAleatorio > 50)
            {
                hapticMaterialToChange.hPopthAbs = (float)3.3;
            }
        }
        condicion = false;
        StartCoroutine(wait1());
    }
    IEnumerator wait1()
    {
        yield return new WaitForSeconds(2);
        plano.SetActive(true);
        StartCoroutine(wait2());
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(2);
        condicion = true;
    }
}
