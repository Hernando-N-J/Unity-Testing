using UnityEngine;
using System.Collections;

// 1. Programación usando el Update.

public class S01MoveScriptB : MonoBehaviour {

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

        if (Cubos[0].transform.position.x < MaxX)
        {
            Cubos[0].transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
        }
        else if (Cubos[1].transform.position.x < MaxX)
        {
            Cubos[1].transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
        }
        else if (Cubos[2].transform.position.x < MaxX)
        {
            Cubos[2].transform.Translate(Velocidad.x * Time.deltaTime, Velocidad.y * Time.deltaTime, Velocidad.z * Time.deltaTime);
        }

    }
}
