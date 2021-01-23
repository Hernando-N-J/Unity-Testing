using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {

	bool detectado;
	MeshRenderer meshRenderer;

	void Awake(){
		meshRenderer = GetComponent<MeshRenderer> ();
	}

	public void Detectado(){
		if (!detectado) {
			detectado = true;
			StartCoroutine(Parpadea());
		}
	}

	IEnumerator Parpadea(){
		for (int c=0; c<10; c++) {
			meshRenderer.enabled = !meshRenderer.enabled;
			yield return new WaitForSeconds(0.25f);
		}
		meshRenderer.enabled = true;
		detectado = false;
	}
	
}
