using UnityEngine;
using System.Collections;

// 1. Mostrar como podemos tener codigo costoso que se ejecuta en cada fotograma

public class S05LessLoadInUpdateA : MonoBehaviour {

	GameObject[] enemigos;

	void Start () {
		enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
	}

	void Update () {
        // Aqui deberia de haber algun codigo costoso que hiciera muchas operaciones.
        // Uso los Debug.Log para simular esa parte costosa, ya que el resto del código
        // de ejemplo no lo es.
        Debug.Log("Inicio de la comprobación");
		foreach(GameObject objeto in enemigos){
            Debug.Log("Comprobando con objeto");
            if (Vector3.Distance(transform.position, objeto.transform.position)<2){
				objeto.GetComponent<Enemigo>().Detectado();
			}
		}

	}
}
