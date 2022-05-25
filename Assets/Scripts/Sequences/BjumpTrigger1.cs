using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BjumpTrigger1 : MonoBehaviour
{
   
    public AudioSource DoorBang;
   // public AudioSource DoorJumpMusic;
    //public GameObject TheZombie;
    public GameObject TheDoor;
    public GameObject EndCanvas;

    void OnTriggerEnter ()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheDoor.GetComponent<Animation>().Play("JumpDoorAnimation");
        DoorBang.Play();
        StartCoroutine(ExitVic());
    
    }

IEnumerator ExitVic(){
 yield return new WaitForSeconds(1.5f);
        EndCanvas.SetActive(true);
}

}