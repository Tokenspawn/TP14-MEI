using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUpObject : MonoBehaviour
{
    int contador = 0;
    public TextMeshProUGUI textoContador;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Coleccionable"))
        {
            contador++;
            textoContador.text = "Objetos: " + contador;
            Destroy(col.gameObject);
        }
    }
}
