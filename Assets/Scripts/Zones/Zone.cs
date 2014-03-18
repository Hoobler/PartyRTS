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

	//Test Stuff tabort senare
	void OnMouseDown(){
		Debug.Log("Mouse clocl");
		ZoneControll();
	}
	
	void OnTriggerEnter(){
		
	}

	void ZoneControll(){
		if(_teamOwner != 1){
			_teamOwner = 1;
			renderer.material.color = Color.red;
			SendToZoneController();
		}
	}
	
	void SendToZoneController(){
		EventManager.TriggerZoneEvent(new ZoneEventArgs(ZoneEnum.GainZone,1));
	}
}
