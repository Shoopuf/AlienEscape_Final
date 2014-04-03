using UnityEngine;
using System.Collections;

public class FanGUI : MonoBehaviour {

	public GlobalVariables vScript;
	public GUIStyle style;

	// Use this for initialization
	void Start () {
//		vScript.CanPlaceFan = false;
	}

	void OnGUI () {
		
		// Make a background box
		GUI.Label (new Rect (5, Screen.height-330, 100, 30), ("Fans: " + vScript.numFans.ToString()),style);

//		if (GUI.Button (new Rect (10,200,40,20), "Up")) {
//			vScript.CanPlaceFan = true;
//			vScript.fanSelected = 1;
//		}else if (GUI.Button (new Rect (10,220,40,20), "Down")) {
//			vScript.CanPlaceFan = true;
//			vScript.fanSelected = 2;
//		}else 

		
	}
	
}
