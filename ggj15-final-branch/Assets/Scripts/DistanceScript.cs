using UnityEngine;
using System.Collections;

public class DistanceScript : ShipComponentScript {
	void Start(){
				Timer = 1.0f;
		isActive = true;
		}

	void Update()
	{
		Timer -= Time.deltaTime;
		if (Timer <= 0) {
						health--;
			Timer=1.0f;
			if (health < 0 || health ==0) {
				Application.LoadLevel ("End Scene Good");
			}
				}


		
	}
	

}