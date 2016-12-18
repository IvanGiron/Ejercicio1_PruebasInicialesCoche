using UnityEngine;
using System.Collections;

public class saltoPollo : MonoBehaviour {
	public float fuerza = 100f;

	// Update is called once per frame
	void Update () { 
		//Si pulso la tecla Espacio
		if(Input.GetKeyDown(KeyCode.Space)){
			//Muestrame en consola Espacio Pulsado
			Debug.Log ("Espacio Pulsado");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up*fuerza);
		}
	}
}
