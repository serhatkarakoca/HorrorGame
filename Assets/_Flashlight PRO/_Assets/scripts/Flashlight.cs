using UnityEngine;
using System.Collections;




public class Flashlight : MonoBehaviour 
{
	
	[SerializeField()] GameObject Lights; // all light effects and spotlight
	[SerializeField()] AudioSource switch_sound; // audio of the switcher
	[SerializeField()] GameObject Battery;



	private Light spotlight;
	private bool is_enabled = false;
	public int batterySize;
	public float batteryStatus;
	

	void Update(){
		 if (Input.GetKeyDown(KeyCode.F))
        {
			Switch();
        }
		/*
		if(is_enabled){
			useEnergy();
		}
		*/
	
	}



	public void Switch()
	{
		if(batterySize>0){

		is_enabled = !is_enabled; 

		Lights.SetActive (is_enabled);

		if (switch_sound != null)
			switch_sound.Play ();

		}
		
		

		//TODO uyarı verilecek 
	}

/*
	public void useEnergy(){
		if(batterySize>0 && is_enabled){
 			if (batteryStatus > 0)
        		{
            batteryStatus -= Time.deltaTime;
       		}
		 if(batteryStatus<=0){
			batterySize--;
		 }	
		 useEnergy();
		}else{
			is_enabled = false;
			Lights.SetActive (is_enabled);
			if (switch_sound != null)
				switch_sound.Play ();
		}
	}
*/

	public void increaseBattery(){
		batteryStatus=100f;
		batterySize++;
	}
}
