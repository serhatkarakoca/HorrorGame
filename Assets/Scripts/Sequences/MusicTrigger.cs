using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
   
    public AudioSource DoorJumpMusic;


    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;    
        StartCoroutine(PlayJumpMusic());
    }

    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();
    }



}