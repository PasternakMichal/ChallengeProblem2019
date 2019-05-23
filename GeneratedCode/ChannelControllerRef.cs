using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChannelControllerRef : MonoBehaviour {
	public Network externalComm;
	public string myName = "Ref";

	void Start () {
		externalComm = new Network(9000,myName,20); // port, net ID, Container size
		externalComm.StartNetwork();
	}

	void Update () {
		if (externalComm.isContainerEmpty () == false) {
			route(externalComm.getMessage());
		}
	}
	
// take out the important information from the message
	public void route(string S){
		if (S != null && S.Equals("")== false && S.Length>0) {
			string name = S.Substring (0, S.IndexOf (','));
			S = cut (S);
// send the message on to the designated recipient inout

	if (name == "player1") {
		player1Script player1 = GetComponentInChildren<player1Script> ();
	
		// send the action name, return the reply that is generated
		string reply = player1.translate (S);
		// if there is a reply send one
		if (reply.Equals("") == false && reply != null&& S.Length>0)
			externalComm.SendMessage("player1,"+reply+";");
		}
	if (name == "player2") {
		player2Script player2 = GetComponentInChildren<player2Script> ();
	
		// send the action name, return the reply that is generated
		string reply = player2.translate (S);
		// if there is a reply send one
		if (reply.Equals("") == false && reply != null&& S.Length>0)
			externalComm.SendMessage("player2,"+reply+";");
		}
	if (name == "player3") {
		player3Script player3 = GetComponentInChildren<player3Script> ();
	
		// send the action name, return the reply that is generated
		string reply = player3.translate (S);
		// if there is a reply send one
		if (reply.Equals("") == false && reply != null&& S.Length>0)
			externalComm.SendMessage("player3,"+reply+";");
		}
	if (name == "player4") {
		player4Script player4 = GetComponentInChildren<player4Script> ();
	
		// send the action name, return the reply that is generated
		string reply = player4.translate (S);
		// if there is a reply send one
		if (reply.Equals("") == false && reply != null&& S.Length>0)
			externalComm.SendMessage("player4,"+reply+";");
		}
	if (name == "ball") {
		ballScript ball = GetComponentInChildren<ballScript> ();
	
		// send the action name, return the reply that is generated
		string reply = ball.translate (S);
		// if there is a reply send one
		if (reply.Equals("") == false && reply != null&& S.Length>0)
			externalComm.SendMessage("ball,"+reply+";");
		}
		}
	}
	public string cut(string message){
		return message.Substring(message.IndexOf(',')+1);
	}
}
