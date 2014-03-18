using UnityEngine;
using System.Collections;
using System;

public delegate void ZoneEvent(ZoneEventArgs derp);

public class EventManager : MonoBehaviour {
	
	public static event ZoneEvent OnZoneEvent;

	public static void TriggerZoneEvent(ZoneEventArgs derp){
		if(OnZoneEvent != null){
			OnZoneEvent(derp);
		}
	}
}
