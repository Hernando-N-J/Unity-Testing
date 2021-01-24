using UnityEngine;
using System.Collections;

// 1. Otra forma de detener las corutinas:
// Hacer que lleguen al final de su ejecución usando variables centinela.
public class S02StopC : MonoBehaviour
{

    bool detener;

    void OnEnable()
    {
        detener = false;
        StartCoroutine(SaludaCadaSegundo());
    }

    void OnDisable()
    {
        detener = true;
    }

    IEnumerator SaludaCadaSegundo()
    {
        int c = 0;
        while (!detener)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            c++;
        }

        Debug.Log("Fin de SaludaCadaSegundo");
    }
}