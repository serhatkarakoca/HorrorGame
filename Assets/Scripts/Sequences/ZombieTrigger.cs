using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{

        public AudioSource DoorJumpMusic;
        public GameObject ThePlayer;
	    public GameObject FadeScreenIn;
        public GameObject Zombie;

    // Start is called before the first frame update
    void Start()
    {
	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator ScenePlayer () {
        Zombie.SetActive(true);
        ThePlayer.GetComponent<FirstPersonController> ().enabled = false;
        yield return new WaitForSeconds (0.3f);
		FadeScreenIn.SetActive(true);
        DoorJumpMusic.Play();
        Zombie.SetActive(false);
        ThePlayer.GetComponent<FirstPersonController> ().enabled = true;
		yield return new WaitForSeconds (5f);
    	FadeScreenIn.SetActive(false);

	}

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;   
        StartCoroutine (ScenePlayer ());
     }

}
