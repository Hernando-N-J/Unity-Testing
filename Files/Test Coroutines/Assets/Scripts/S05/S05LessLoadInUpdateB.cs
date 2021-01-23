using UnityEngine;
using System.Collections;

// 1. Ahora el codigo costoso se ejecuta menos veces por segundo y sobrecarga mucho menos.

public class S05LessLoadInUpdateB : MonoBehaviour {

	GameObject[] enemigos;

	void Start () {
		enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
		StartCoroutine (CodigoCostoso ());
	}

	IEnumerator CodigoCostoso(){
		while (true) {
            // Codigo costoso pasado a una corrutina para que se ejecute menos veces por segundo
            Debug.Log("Inicio de la comprobación");
            foreach (GameObject objeto in enemigos)
            {
                Debug.Log("Comprobando con objeto");
                if (Vector3.Distance(transform.position, objeto.transform.position) < 2)
                {
                    objeto.GetComponent<Enemigo>().Detectado();
                }
            }
            yield return new WaitForSeconds(0.2f);
		}
	}
}
