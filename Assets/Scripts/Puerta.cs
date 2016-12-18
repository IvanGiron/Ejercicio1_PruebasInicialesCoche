using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {
	HingeJoint2D bisagra;
	JointMotor2D motor;


	// Use this for initialization
	void Start () {
		bisagra = GetComponent<HingeJoint2D> ();
		motor = bisagra.motor;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			motor.motorSpeed = 100f;
			bisagra.motor = motor;
			bisagra.useMotor = true;
		}

		if (Input.GetKeyUp (KeyCode.T)) {
			motor.motorSpeed = 0f;
			bisagra.motor = motor;
			bisagra.useMotor = false;
		}
	}
}
