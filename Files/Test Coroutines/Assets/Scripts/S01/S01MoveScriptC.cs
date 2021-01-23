using UnityEngine;
using System.Collections;

// 1. Funcionamiento de la corutina.
// 2. Orden de ejecución de los elementos.

public class S01MoveScriptC : MonoBehaviour {

    private GameObject[] Cubos;
    private Vector3 Velocidad;
    private const float MaxX = 8.345f;

    void Start()
    {
        Cubos = new GameObject[3];
        Cubos[0] = GameObject.Find("CuboA");
        Cubos[1] = GameObject.Find("CuboB");
        Cubos[2] = GameObject.Find("CuboC");
        Velocidad = new Vector3(7f, 0f, 0f);

        StartCoroutine(MoverCubos());

        //Debug.Log("Fin del Start");
    }

    void Update () {

	}

    IEnumerator MoverCubos()
    {
        foreach (GameObject cubo in Cubos)
        {
            while (cubo.transform.position.x < MaxX)
            {
                cubo.transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
                yield return null;
            }
        }

        //Debug.Log("Fin de MoverCubos()");
    }

}
