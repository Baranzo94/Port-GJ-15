using UnityEngine;
using System.Collections;

public class EngineScript : ShipComponentScript
{
	public RandomEvents random;
	// Update is called once per frame
	void Update()
	{
		if (isActive == true)
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				BatteryScript.power += -5;
				health++;
				Timer = 1.0f;
			}
		}
		if (isActive == false)
						
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				if(random.EngineEvent==true)
				{
					health = health -3;
					Timer = 1.0f;
				}
				else{
				health--;
				Timer=1.0f;
				}
			}
		}

		if(health <= 0) {
			
			Application.LoadLevel ("Middle Scene");
			
		}

	}

	public void Activate()
	{
		BatteryScript.activatedEngines = true;
		BatteryScript.charging = false;
		isActive = true;
		activateButton.SetActive(false);
		deactivateButton.SetActive(true);
	}

	public override void Deactivate()
	{
		BatteryScript.activatedEngines = false;
		isActive = false;
		activateButton.SetActive(true);
		deactivateButton.SetActive(false);
	}
}