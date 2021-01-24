using UnityEngine;
using System.Collections;

// Iniciar y detener alguna corrutina en concreto usando el StopCoroutine.
// Desventajas: No poder pasar parámetros.

public class S03StartStopA : MonoBehaviour {

    public Light luz;

    public void ComenzarParpadeo()
    {
        StartCoroutine("Parpadeo");
    }

    public void DetenerParpadeo()
    {
        StopCoroutine("Parpadeo");
    }

    public void ComenzarCambioColor()
    {
        StartCoroutine("CambioColor");
    }

    public void DetenerCambioColor()
    {
        StopCoroutine("CambioColor");
    }

    IEnumerator Parpadeo()
    {
        while (true)
        {
            for(int c = 0; c<20; c++)
            {
                luz.enabled = !luz.enabled;
                yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            }
            luz.enabled = Random.Range(0, 2) == 0 ? true : false;
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator CambioColor()
    {
        while (true)
        {
            luz.color = Color.Lerp(Color.white, Color.blue, Mathf.PingPong(Time.time / 2, 1));
            yield return null;
        }
    }


}
