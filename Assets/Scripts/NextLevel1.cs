﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Para que se pueda cambiar de escena

public class NextLevel1 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D objeto){
		if ((objeto.tag == "Player")) {
			SceneManager.LoadScene  ("Level1");
		}
	}
}