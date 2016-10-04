using UnityEngine;
using System.Collections;

public class NavigationCoreScript : ShipComponentScript {
	public RandomEvents random;
	// Update is called once per frame
	void Update () {

		if (isActive ==true)
		{
			
			Timer-= Time.deltaTime;
			if( Timer<=0)
			{
				BatteryScript.power+=-5;
				Timer=1.0f;
				health++;
			}
			
			
		}
		if (isActive == false) {
						Timer -= Time.deltaTime;
						if (Timer <= 0) {
								if(random.NavigationCoreEvent==true)
				{
					health= health -3;
					Timer=1.0f;
				}
				else{
							
								health--;
								Timer=1.0f;
				}

						}
				}
}

	public void Activate(){
		BatteryScript.activatedNavCore = true;
		BatteryScript.charging = false;
		isActive = true;
		activateButton.SetActive(false);
		deactivateButton.SetActive(true);
	}
	
	public override void Deactivate(){
		BatteryScript.activatedNavCore = false;
		isActive = false;
		activateButton.SetActive(true);
		deactivateButton.SetActive(false);
	}
}
