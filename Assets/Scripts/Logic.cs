using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour {

	public static int 	point;
	public int 			plim;
	public Text 		pointT;

	public float timeF;
	public int 	 timeI;
	public Text  timeT;

	public static int 	contApples;

	void Update () {
		plim = point;
		pointT.text = ((plim*10).ToString ());

		timeF += Time.deltaTime;
		timeI = (int)timeF;

		int timeX = 60 - timeI;

		timeT.text = (timeX.ToString ());

		if (timeX == 0){
			SceneManager.LoadScene ("OtherScene");
		}

	}
}
