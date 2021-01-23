#pragma warning disable 162

using UnityEngine;
using System.Collections;

// 1. Otra forma de detener las corutinas:
// Terminar "a lo bestia" usando "yield break;"
// (Mostrar qué pasa usando sólo break)
public class S02StopD : MonoBehaviour
{
    bool detener;

    void OnEnable() { detener = false; StartCoroutine(SaludaCadaSegundo()); }

    void OnDisable() { detener = true; }

    IEnumerator SaludaCadaSegundo()
    {
        int c = 0;
        while (true)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            if (detener) { yield break;
                //break; // también hubiera valido en este caso.
            }
            c++;
        }
        Debug.Log("Fin de SaludaCadaSegundo");
    }
}