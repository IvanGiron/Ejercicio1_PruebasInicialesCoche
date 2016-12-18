using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Para que se pueda cambiar de escena

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			reiniciar ();
		}
	}

	public void reiniciar(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		Debug.Log ("Me Reinicio Mardito");
	}

	public void cargarNivel(int nivel){
		SceneManager.LoadScene (nivel);
	}
}
