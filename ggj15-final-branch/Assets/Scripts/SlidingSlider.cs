using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlidingSlider : MonoBehaviour
{
	public GameObject slider;
	public GameObject audioSource;
	public ShipComponentScript shipComponent;
	Slider slider_;

	public void Start()
	{
		slider_ = slider.GetComponent<Slider>();
	}

	public void Update()
	{
		if (slider_ && shipComponent)
			slider_.value = shipComponent.health / 100.0f;
		if (shipComponent.health <= 10 && shipComponent.health >=9) {

						PlayAudio (); 

		} 
		if(shipComponent.health <= 0) {

			Application.LoadLevel ("Middle Scene");

		}
	}




	public void OnSliderChange()
	{
		Debug.Log("Slider value: " + shipComponent.health);
	}

	public void PlayAudio(){
		//if (shipComponent.health <= 10) {
			//	audioSource = GameObject.Find ("WarningSystem");
		//}

		audioSource.GetComponent<AudioSource>().enabled = true;
		if (!audioSource.GetComponent<AudioSource>().isPlaying) { 
						audioSource.GetComponent<AudioSource>().enabled = false;
				}

	}

}
