using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public GUIStyle restartStyle;
	public GUIStyle backStyle;
	public GUIStyle nextStyle;
	public int levelNum;
	// Use this for initialization
	void Start () {

	}
	void OnGUI () {
		if (GUI.Button (new Rect (10,Screen.height - 50,40,40), " ", restartStyle)) {
			Application.LoadLevel (Application.loadedLevel);
		}
		if (GUI.Button (new Rect (60,Screen.height - 50,40,40), " ", backStyle)) {
			Application.LoadLevel (2);
		}
		if (GUI.Button (new Rect (110,Screen.height - 50,40,40), " ", nextStyle)) {
			Application.LoadLevel (Application.loadedLevel+1);
		}

	}
	// Update is called once per frame
	void Update () {

//		if(Input.GetMouseButtonDown(0)){
//			Application.LoadLevel (3);
//		}
	}
}
