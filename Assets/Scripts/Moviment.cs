using UnityEngine;
using System.Collections;

public class Moviment : MonoBehaviour {

	public float vel;

	public ParticleSystem part;

	void Start () {
	
	}
	
	void Update () {

		float translation = Input.GetAxis("Vertical") * vel;
		float rotation 	  = Input.GetAxis("Horizontal") * vel*30;

		translation *= Time.deltaTime;
		rotation 	*= Time.deltaTime;

		transform.Translate	(0, 0, translation);
		transform.Rotate	(0, rotation, 0);

	}

	void OnTriggerEnter (Collider c) {

		if (c.name == "Apple"){
			part.Play ();
		
		}	

	}
}
