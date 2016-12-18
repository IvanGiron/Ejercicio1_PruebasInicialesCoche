using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			Destroy (gameObject);
		}

	}

}
