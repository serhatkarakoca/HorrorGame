using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityModularFirstPersonController.FirstPersonController.FirstPersonController;
using UnityEngine.UI;

public class Baslangıc : MonoBehaviour
{
	public GameObject ThePlayer;
	public GameObject FadeScreenIn;
	public GameObject TextBox;

	void Start () {
		ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
		StartCoroutine (ScenePlayer ());
	}

	IEnumerator ScenePlayer () {
		yield return new WaitForSeconds (1.5f);
		FadeScreenIn.SetActive(false);
		TextBox.GetComponent<Text>().text = "I need to get out of here.";
		yield return new WaitForSeconds (2);
		TextBox.GetComponent<Text> ().text = "";
		ThePlayer.GetComponent<FirstPersonController> ().enabled = true;

	}

} 