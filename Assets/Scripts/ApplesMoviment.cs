using UnityEngine;
using System.Collections;

public class ApplesMoviment : MonoBehaviour {

	public float vel;

	public Vector3	start = new Vector3 (Random.Range (-10.0f,10.0f), 15.0f, Random.Range(-10.0f,10.0f));



	void Start () {

	}



	void Update () {

		start = new Vector3 (Random.Range (-10.0f,10.0f), 15.0f, Random.Range(-10.0f,10.0f));

		transform.Translate (0, -vel * Time.deltaTime, 0);

		if (transform.position.y < -1){
			transform.position = start;
		}

	}


	void OnTriggerEnter (Collider c) {

		if (c.name == "Player"){
			transform.position = start;
			Logic.point++;
		}	

	}

}
