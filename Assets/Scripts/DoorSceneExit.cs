using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorSceneExit : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject FadeOut;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 2) {
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
			 ActionText.GetComponent<Text>().text = "Open the door";
		}
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					FadeOut.SetActive(true);
					StartCoroutine(FadeToExit());
				}
				
			}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive(false);
	}
	IEnumerator FadeToExit()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(2);
		
	}
}