using UnityEngine;
using System.Collections;

// 1. Presentar el problema. Concepto de Update en Unity.

public class S01MoveScriptA : MonoBehaviour {

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
    }

    void Update () {
        foreach(GameObject cubo in Cubos)
        {
            while(cubo.transform.position.x < MaxX)
            {
                cubo.transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
            }
        }
	}
}
