using UnityEngine;
using System.Collections;

public class Zone : MonoBehaviour {

	public int ResourceAmount;

	private int _teamOwner;

	// Use this for initialization
	void Start () {
		_teamOwner = -1;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Test Stuff tabort senare
	void OnMouseDown(){
		Debug.Log("Mouse left click");
		ZoneControll(0);
	}
	
	void OnTriggerEnter(){
		
	}

	void ZoneControll(int derp){
		if(_teamOwner != 1){
			_teamOwner = 1;
			renderer.material.color = Color.red;
			SendToZoneController(0);
		}
		else if(_teamOwner == 1){
			_teamOwner = -1;
			renderer.material.color = Color.white;
			SendToZoneController(1);
		}
	}
	
	void SendToZoneController(int zone){
		if(zone == 0){
			EventManager.TriggerZoneEvent(new ZoneEventArgs(ZoneEnum.GainZone,1, 1));
		}
		else if(zone == 1){
			EventManager.TriggerZoneEvent(new ZoneEventArgs(ZoneEnum.LoseZone,1, 1));
		}

	}
}
