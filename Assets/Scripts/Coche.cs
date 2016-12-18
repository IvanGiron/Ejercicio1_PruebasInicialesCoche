using UnityEngine;
using System.Collections;

public class Coche : MonoBehaviour {
	WheelJoint2D unionRueda;

	// Use this for initialization
	void Start () {
		unionRueda = GetComponent<WheelJoint2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			unionRueda.useMotor = !unionRueda.useMotor;
		}
	
	}
}
