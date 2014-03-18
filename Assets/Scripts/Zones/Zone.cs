using UnityEngine;
using System.Collections;

public class Zone : MonoBehaviour {

	private int _teamOwner;

	// Use this for initialization
	void Start () {
		_teamOwner = -1;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(){
		
	}
	
	void SendToZoneController(){
		EventManager.TriggerZoneEvent(new ZoneEventArgs(ZoneEnum.GainZone,1));
	}
}
