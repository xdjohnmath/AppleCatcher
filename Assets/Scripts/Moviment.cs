using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour {

	public float vel; 

	public ParticleSystem part, folhenhas;

	void Start () {
	
	}
	
	void Update () {

		float translation = Input.GetAxis("Vertical") * vel;
		float rotation 	  = Input.GetAxis("Horizontal") * vel*30;

		translation *= Time.deltaTime;
		rotation 	*= Time.deltaTime;

		transform.Translate	(0, 0, translation);
		transform.Rotate	(0, rotation, 0);

	// Para as folhenhas suberem           //BUG
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
			folhenhas.Play ();
		} else if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow)) {
			folhenhas.Stop ();
		}
	}


	void OnTriggerEnter (Collider c) {

		if (c.name == "Apple"){
			part.Play ();
		}
			
	}
}
