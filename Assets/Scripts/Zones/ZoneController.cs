using UnityEngine;
using System.Collections;

public class ZoneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		EventManager.OnZoneEvent += EventRespons;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void EventRespons(ZoneEventArgs derp){
		if(derp.ZoneState == ZoneEnum.GainZone){
			
		}
		else if(derp.ZoneState == ZoneEnum.LoseZone){
		
		}
		else if(derp.ZoneState == ZoneEnum.NeutralZone){
		
		}
	}
}
