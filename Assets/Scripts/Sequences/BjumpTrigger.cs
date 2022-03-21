using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BjumpTrigger : MonoBehaviour
{
   
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    //public GameObject TheZombie;
    public GameObject TheDoor;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnimation");
        DoorBang.Play();
       // TheZombie.SetActive(true);
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();
    }



}