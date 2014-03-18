using UnityEngine;
using System.Collections;

public class ZoneController : MonoBehaviour {

	private int _zones;

	// Use this for initialization
	void Start () {
		EventManager.OnZoneEvent += EventRespons;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void EventRespons(ZoneEventArgs derp){
		if(derp.ZoneState == ZoneEnum.GainZone){
			_zones++;
		}
		else if(derp.ZoneState == ZoneEnum.LoseZone){
		
		}
		else if(derp.ZoneState == ZoneEnum.NeutralZone){
		
		}
		Debug.Log("Zones controlled: " + _zones);
	}
}
