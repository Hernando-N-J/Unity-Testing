#pragma warning disable 162

using UnityEngine;
using System.Collections;

// 1. Corrutinas activas siempre que el componente esté activo.
// 2. Demostrar que el StopAllCoroutines detiene todas las corrutinas iniciadas por este componente.

public class S02StopB : MonoBehaviour {

	void OnEnable () {
        StartCoroutine(SaludaCadaSegundo());
	}

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator SaludaCadaSegundo()
    {
        int c = 0;
        while (true)
        {
            Debug.Log("Hola " + c);
            yield return new WaitForSeconds(1f);
            c++;
        }

        Debug.Log("Fin de SaludaCadaSegundo");
    }
}
