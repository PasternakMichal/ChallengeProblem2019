using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starter : MonoBehaviour {
// ---- These must be assigned as prefabs in Unity and as "metaobjects" in the DSL
	public sateliteCameraScript Camera;


	GameObject CameraObject;
GameObject surfaceObject;
GameObject player1Object;
GameObject player2Object;
GameObject player3Object;
GameObject player4Object;
GameObject ballObject;
//-----
	void Start () {
	Application.runInBackground = true;
//-- adding the necessary instances
	CameraObject = (GameObject)Instantiate (Resources.Load("CameraController"),transform);

   	surfaceObject = (GameObject)Instantiate (Resources.Load("Field"),transform);
   	surfaceObject.AddComponent<surfaceScript>();
   	player1Object = (GameObject)Instantiate (Resources.Load("Piece"),transform);
   	player1Object.AddComponent<player1Script>();
   	// player2Object = (GameObject)Instantiate (Resources.Load("Piece"),transform);
   	// player2Object.AddComponent<player2Script>();
   	player3Object = (GameObject)Instantiate (Resources.Load("Piece"),transform);
   	player3Object.AddComponent<player3Script>();
   	// player4Object = (GameObject)Instantiate (Resources.Load("Piece"),transform);
   	// player4Object.AddComponent<player4Script>();
   	ballObject = (GameObject)Instantiate (Resources.Load("Ball"),transform);
   	ballObject.AddComponent<ballScript>();
//adding the necessary channel information scripts
	Camera = CameraObject.GetComponent<sateliteCameraScript>();
   	Camera.observedObject = surfaceObject;
   	Camera.off = new Vector3(0.0f,65.0f,0.0f);
    Camera.transform.Rotate(60,0,0);
   	// gameObject.AddComponent<ChannelControllerRef>();
   	gameObject.AddComponent<ChannelControllerc1>();
   	// gameObject.AddComponent<ChannelControllerc2>();
   	gameObject.AddComponent<ChannelControllerc3>();
   	// gameObject.AddComponent<ChannelControllerc4>();
	}
		void Update(){//

			if (Input.GetKeyDown(KeyCode.Alpha1)){
				Camera.observedObject = surfaceObject;
			}

			if (Input.GetKeyDown(KeyCode.Alpha2)){
				Camera.observedObject = player1Object;
			}

			if (Input.GetKeyDown(KeyCode.Alpha3)){
				Camera.observedObject = player2Object;
			}

			if (Input.GetKeyDown(KeyCode.Alpha4)){
				Camera.observedObject = player3Object;
			}

			if (Input.GetKeyDown(KeyCode.Alpha5)){
				Camera.observedObject = player4Object;
			}

			if (Input.GetKeyDown(KeyCode.Alpha6)){
				Camera.observedObject = ballObject;
			}
			if (Input.GetKeyDown(KeyCode.Z)){
				Camera.follow = true;
			}
			if (Input.GetKeyDown(KeyCode.X)){
				Camera.follow = false;
			}
			if (Input.GetKeyDown(KeyCode.LeftArrow)){
						Camera.transform.Rotate (0, -10, 0);
					}
					if (Input.GetKeyDown(KeyCode.RightArrow)){
						Camera.transform.Rotate (0, 10, 0);
					}
		}
}
