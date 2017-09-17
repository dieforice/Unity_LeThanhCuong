using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timers : MonoBehaviour {
	public int Time;
	public string TimeString;
	public Text TimeText;
	void Start () {
		StartCoroutine ("PlayTimer");
	}
	public IEnumerator PlayTimer()
	{
		while (true) {
			string TimeString = Time.ToString ();
			TimeText.text = TimeString;
			yield return new WaitForSeconds (1);
			Time -= 1;
			print ("hello");

		}

	}

}
