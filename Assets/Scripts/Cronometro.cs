using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Importante para que funionen el UI

public class Cronometro : MonoBehaviour {

	float tiempo =0;
	public Text tiempoText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;
		tiempoText.text = "" + tiempo;


	}

	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			
		}

}
}