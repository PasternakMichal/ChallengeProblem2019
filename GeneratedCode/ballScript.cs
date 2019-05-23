using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ballScript : BallMetaObject {
	public string channelID;

	// --- auto declare all "properties"
	// --- End auto declare properties

	// --- Initialize object size/position
	void Start(){
		requiredStart();
		t.localScale = new Vector3 (1.5f,1.5f,1.5f);
		t.localPosition = new Vector3(0.0f,5.0f,0.0f);
		t.Rotate( new Vector3 (0.0f,0.0f,0.0f) );
	// --- Initialize start Variables
	}
	// --- End start function

	// --- Add all new actions

	// -- DSL generated "actions"
   	public string GPS(){
double ret;
double ret2;
double ret3;
   			ret = t.localPosition.x;
   			ret2 = t.localPosition.y;
   			ret3 = t.localPosition.z;
   			return ret+","+ret3+"";
   		}
	// --- End adding all new actions
	// --- Overide existing actions
	// --- End overrideActions

	// --- Begin message handling
	public string translate(string message){
	//--Get parameters as strings.
		string name = message.Substring (0, message.IndexOf ('('));
		message = cut(message,'(');
		string [] param = extractParam(message);

   		if(name == "GPS"){
   			return ""+ GPS();
   		}
   		return "";
	}
	// --- End message handling
}
