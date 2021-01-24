using UnityEngine;
using System.Collections;

// 1. Mostrar cuando Unity deja de ejecutar las corutinas de un objeto.
// (Desactivar el componente y desactivar el objeto)

public class S02StopA : MonoBehaviour {

	void Start () {
        StartCoroutine(SaludaCadaSegundo());
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
    }
}
