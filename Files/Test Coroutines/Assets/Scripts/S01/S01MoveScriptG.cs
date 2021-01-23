using UnityEngine;
using System.Collections;

// Versión final
// 1. Repasar la ejecución paso a paso.

public class S01MoveScriptG : MonoBehaviour {

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
            cubo.GetComponent<MeshRenderer>().material.color = Color.green;
            yield return new WaitForSeconds(2f);

            yield return StartCoroutine(GirarCubo(cubo));
            cubo.GetComponent<MeshRenderer>().material.color = Color.red;
            yield return new WaitForSeconds(2f);
        }
    }


    IEnumerator GirarCubo(GameObject cubo)
    {
        Vector3 VelocidadRotacion = new Vector3(0, 0, 50f);
        while(cubo.transform.rotation.eulerAngles.z < 90)
        {
            Vector3 anguloActual = cubo.transform.rotation.eulerAngles;
            cubo.transform.rotation = Quaternion.Euler(anguloActual + VelocidadRotacion * Time.deltaTime);
            yield return null;
        }
    }

}
