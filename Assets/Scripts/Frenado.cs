using UnityEngine;
using System.Collections;

public class Frenado : MonoBehaviour {
	Rigidbody2D parar;
	// Use this for initialization
	void Start () {
		parar = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			parar.freezeRotation = !parar.freezeRotation;
		}
	}
}
