using UnityEngine;
using System.Collections;
using System;

public class ZoneEventArgs : EventArgs {

	public ZoneEventArgs(ZoneEnum zoneEnum, int team){
		this.Team = team;
		this.ZoneState = zoneEnum;
	}
	
	public int Team{ get; private set; }
	public ZoneEnum ZoneState{ get; private set; }
}
