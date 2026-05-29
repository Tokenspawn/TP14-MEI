using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    int contador = 0;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coleccionable"))
        {
            contador++;

            Debug.Log("Objetos recolectados: " + contador);

            Destroy(col.gameObject);
        }
    }
}
