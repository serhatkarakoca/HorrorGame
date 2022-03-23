using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeObjects : MonoBehaviour
{
    public Flashlight flashlight;
    public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public AudioSource TakeSound;
    public GameObject Light;

   
	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 2) {
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
            ActionText.GetComponent<Text>().text = "Take";

		}
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
                if(this.gameObject.CompareTag("battery"))
                    flashlight.increaseBattery();
                if(this.gameObject.CompareTag("flashlight"))
                    Light.gameObject.SetActive(true);

                this.gameObject.SetActive(false);
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				TakeSound.Play ();
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
