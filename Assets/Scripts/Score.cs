using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {


	public Text texto;

	void Start () {
	
	}
	

	void Update () {

		texto.text = ((Logic.point*10).ToString ());

	}

	public void Play(){

		SceneManager.LoadScene ("Principal");

		Logic.point = 0;

	}
}
