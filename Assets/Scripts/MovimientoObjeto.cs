using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoObjeto : MonoBehaviour
{
    public float velocidad = 1f; // velocidad de movimiento del objeto
    public float velocidadRotacion = 1f;//velocidad rotation

    // Función que se llama en cada frame
    void Update()
    {
        // Movimiento en el eje X
        if (Input.GetKey(KeyCode.RightArrow)) // si se presiona la tecla de flecha derecha
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime); // mover hacia la derecha
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) // si se presiona la tecla de flecha izquierda
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime); // mover hacia la izquierda
        }

        // Movimiento en el eje Y
        if (Input.GetKey(KeyCode.UpArrow)) // si se presiona la tecla de flecha arriba
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime); // mover hacia arriba
        }
        else if (Input.GetKey(KeyCode.DownArrow)) // si se presiona la tecla de flecha abajo
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime); // mover hacia abajo
        }

        // Movimiento en el eje Z
        if (Input.GetKey(KeyCode.W)) // si se presiona la tecla "W"
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime); // mover hacia adelante
        }
        else if (Input.GetKey(KeyCode.S)) // si se presiona la tecla "S"
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime); // mover hacia atrás
        }
        //ROTATION
        if (Input.GetKey(KeyCode.R))
        {
            // Obtener la rotación actual del objeto
            float rotacionZ = transform.rotation.eulerAngles.z + velocidadRotacion * Time.deltaTime;

            // Calcular la rotación gradual hacia la nueva posición
            Quaternion rotacionDeseada = Quaternion.Euler(0, 0, rotacionZ);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotacionDeseada, velocidadRotacion * Time.deltaTime);
        }
    }

}