using UnityEngine;
using System.Collections;
using System;

public class ZoneEventArgs : EventArgs {

	public ZoneEventArgs(ZoneEnum zoneEnum, int team,int res){
		this.Team = team;
		this.ZoneState = zoneEnum;
		this.ZoneRes = res;
	}
	
	public int Team{ get; private set; }
	public int ZoneRes{ get; private set; }
	public ZoneEnum ZoneState{ get; private set; }
}
