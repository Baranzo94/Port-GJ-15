using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RandomEvents : MonoBehaviour
{
	public Text text;
	public List<string> events;
	float timer;
	public bool EngineEvent = false;
	public bool NavigationCoreEvent = false;
	public bool LifeSupportEvent = false;
	public bool CommunicationsEvent = false;

	void Update()
	{
		if (events.Count == 0)
			return;

		timer += Time.deltaTime;
		if (timer >= 5 && Random.Range(0.0f, 1.0f) <= 0.005f)
		{
			int index = Random.Range(0, events.Count - 1);
			string eventText = events[index];

			if(events[index] ==events[0])
			{
				EngineEvent = true;
				NavigationCoreEvent = false;
				LifeSupportEvent = false;
				CommunicationsEvent = false;
			}
			if(events[index] ==events[1])
			{
				EngineEvent = false;
				NavigationCoreEvent = true;
				LifeSupportEvent = false;
				CommunicationsEvent = false;
			}
			if(events[index] ==events[2])
			{
				EngineEvent = false;
				NavigationCoreEvent = false;
				LifeSupportEvent = true;
				CommunicationsEvent = false;
			}
			
			if(events[index] ==events[3])
			{
				EngineEvent = false;
				NavigationCoreEvent = false;
				LifeSupportEvent = false;
				CommunicationsEvent = true;
			}

			if(events[index] ==events[4])
			   {
				EngineEvent = false;
				NavigationCoreEvent = false;
				LifeSupportEvent = false;
				CommunicationsEvent = false;
			}
			//events.RemoveAt(index);
			timer = 0;

			text.text = eventText;
		}
	}
}
