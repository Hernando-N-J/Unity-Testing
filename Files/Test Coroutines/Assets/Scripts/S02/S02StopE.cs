using UnityEngine;
using System.Collections;

// 1. Paso de parámetros a las corutinas

public class S02StopE : MonoBehaviour
{

    void OnEnable()
    {
        StartCoroutine(SaludaCadaSegundo("Hola a todos", 1f));
        StartCoroutine(SaludaCadaSegundo("Adios a todos", 1f));
        StartCoroutine(SaludaCadaSegundo("...", .25f));
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator SaludaCadaSegundo(string mensaje, float espera)
    {
        while (true)
        {
            Debug.Log(mensaje);
            yield return new WaitForSeconds(espera);
        }
    }

}