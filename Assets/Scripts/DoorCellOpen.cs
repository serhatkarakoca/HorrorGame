using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	public AudioSource LockedSound;
	public GameManagerScript gm;

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
				if(TheDoor.gameObject.tag != "locked"){
					this.GetComponent<BoxCollider>().enabled = false;
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					TheDoor.GetComponent<Animation> ().Play ("KapiAnimasyonu");
					CreakSound.Play ();
				}else{
					if(TheDoor.gameObject.tag == "locked" && gm.hasKey==true){
					gm.hasKey = false;
					this.GetComponent<BoxCollider>().enabled = false;
					ActionDisplay.SetActive(false);
					ActionText.SetActive(false);
					TheDoor.GetComponent<Animation> ().Play ("KapiAnimasyonu");
					CreakSound.Play ();
				}else{
					LockedSound.Play();
				}
					
				}
				
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
