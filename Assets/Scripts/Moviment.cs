using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour {

	public 	float 	 vel; 
	private Animator anim;

	public ParticleSystem part, folhenhas;

	void Start () {
		anim = GetComponent <Animator> ();

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

			anim.SetInteger ("Walking", 1);

		} else if (Input.GetKeyUp (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.DownArrow) || Input.GetKeyUp (KeyCode.LeftArrow) || Input.GetKeyUp (KeyCode.RightArrow)) {
			folhenhas.Stop ();

			anim.SetInteger ("Walking", 0);
		}
	}


	void OnTriggerEnter (Collider c) {

		if (c.name == "Apple"){
			part.Play ();
		}
			
	}
}
