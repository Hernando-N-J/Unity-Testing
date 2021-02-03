using UnityEngine;
using System.Collections;

// Iniciar y detener alguna corrutina en concreto usando variables centinela.

public class S04StartStopB : MonoBehaviour {

    public Light luz;
    bool parpadeoActivo, cambioColorActivo;

    public void ComenzarParpadeo() {
        parpadeoActivo = true;
        StartCoroutine(Parpadeo());
    }

    public void ComenzarCambioColor(){
        cambioColorActivo = true;
        StartCoroutine(CambioColor());
    }
    
    public void DetenerParpadeo() { parpadeoActivo = false; }
    public void DetenerCambioColor() { cambioColorActivo = false; }

    IEnumerator Parpadeo() {
        while (parpadeoActivo){
            for(int c = 0; c<20 && parpadeoActivo; c++){
                luz.enabled = !luz.enabled;
                yield return new WaitForSeconds(Random.Range(0.01f, 0.1f));
            }
            luz.enabled = Random.Range(0, 2) == 0 ? true : false;
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator CambioColor() {
        while (cambioColorActivo) {
            luz.color = Color.Lerp(Color.white, Color.blue, Mathf.PingPong(Time.time / 2, 1));
            yield return null;
        }
    }


}
