using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class player4Script : PieceMetaObject {
	public string channelID;

	// --- auto declare all "properties"
	// --- End auto declare properties

	// --- Initialize object size/position
	void Start(){
		requiredStart();
		t.localScale = new Vector3 (0.6f,0.6f,0.6f);
		t.localPosition = new Vector3(30.0f,1.3f,-8.0f);
		t.Rotate( new Vector3 (0.0f,180.0f,0.0f) );
	// --- Initialize start Variables
		pi.team = 1;
	}
	// --- End start function
	
	// --- Add all new actions

	// -- DSL generated "actions"
   	public void moveForward(double amount){
   			pi.FBpower = amount;
   		}
   	public void moveRight(double amount){
   			pi.LRpower = amount;
   		}
   	public void setMovement(double fb,double lr,double s){
   			pi.FBpower = fb;
   			pi.LRpower = lr;
   			pi.spin = s;
   		}
   	public string GPS(){
double ret;
double ret2;
   			ret = posx;
   			ret2 = posz;
   			return ret+","+ret2+"";
   		}
   	public string getTilt(){
double ret;
   			ret = pi.tilt;
   			return ret+"";
   		}
   	public string getSuction(){
double ret;
   			ret = pi.suction;
   			return ret+"";
   		}
   	public void setSuction(double amount){
   			pi.suction = amount;
   		}
   	public void setTilt(double amount){
   			pi.tilt = amount;
   		}
   	public void spin(double amount){
   			pi.spin = amount;
   		}
   	public void stop(){
   			pi.FBpower = 0;
   			pi.LRpower = 0;
   			pi.spin = 0;
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

   		if(name == "moveForward"){
   			 moveForward(double.Parse(param[0])
);
   		}
   		if(name == "moveRight"){
   			 moveRight(double.Parse(param[0])
);
   		}
   		if(name == "setMovement"){
   			 setMovement(double.Parse(param[0])
,double.Parse(param[1])
,double.Parse(param[2])
);
   		}
   		if(name == "GPS"){
   			return ""+ GPS();
   		}
   		if(name == "getTilt"){
   			return ""+ getTilt();
   		}
   		if(name == "getSuction"){
   			return ""+ getSuction();
   		}
   		if(name == "setSuction"){
   			 setSuction(double.Parse(param[0])
);
   		}
   		if(name == "setTilt"){
   			 setTilt(double.Parse(param[0])
);
   		}
   		if(name == "spin"){
   			 spin(double.Parse(param[0])
);
   		}
   		if(name == "stop"){
   			 stop();
   		}
   		return "";
	}
	// --- End message handling
}
