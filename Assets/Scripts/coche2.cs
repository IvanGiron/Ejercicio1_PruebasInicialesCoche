using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Importante para que funionen el UI

public class coche2 : MonoBehaviour {
	// Definimos una variable para meter dentro el componente WheelJoint2D
	WheelJoint2D union_rueda; 
	JointMotor2D motor;
	float velocidad= 0f;
	public Text textoVelocimetro;

	void Start () {
		//Metemos la información del componente WheelJoint2D en la variable
		union_rueda = GetComponent<WheelJoint2D> ();
		motor = union_rueda.motor; 

	}

	void Update () {

		velocidad = GetComponent<Rigidbody2D> ().velocity.magnitude;
		textoVelocimetro.text= ""+Mathf.Round(velocidad*10)+" Km/h";

		// Vemos si pulsamos la tecla espacio
		if (Input.GetKey (KeyCode.Space)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = true;
			motor.motorSpeed = union_rueda.motor.motorSpeed - 5f;
			union_rueda.motor = motor;
		} 

		if (Input.GetKeyUp (KeyCode.Space)){
			motor.motorSpeed = 0f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}

		if (Input.GetKey (KeyCode.Z)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = true;
			motor.motorSpeed = union_rueda.motor.motorSpeed - -5f;
			union_rueda.motor = motor;
		} 

		if (Input.GetKeyUp (KeyCode.Z)){
			motor.motorSpeed = 0f;
			union_rueda.motor = motor;
			union_rueda.useMotor = false;
		}



	}
}
