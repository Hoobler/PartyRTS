using UnityEngine;
using System.Collections;

public class ZoneController : MonoBehaviour {

	private int _zones;
	private int[] _array;

	// Use this for initialization
	void Start () {
		_array = new int[4];
		EventManager.OnZoneEvent += EventRespons;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void EventRespons(ZoneEventArgs derp){
		if(derp.ZoneState == ZoneEnum.GainZone){
			_array[derp.Team]++;
		}
		else if(derp.ZoneState == ZoneEnum.LoseZone){
			_array[derp.Team]--;
		}
		else if(derp.ZoneState == ZoneEnum.NeutralZone){
		
		}
		Debug.Log("Zones controlled: " + _array[derp.Team]);
	}
}
