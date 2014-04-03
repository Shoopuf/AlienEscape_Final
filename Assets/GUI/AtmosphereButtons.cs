using UnityEngine;
using System.Collections;

public class AtmosphereButtons : MonoBehaviour {
	public GlobalVariables varsScript;

	public float oxygenValue = 0;
	public float hexaneValue = -7;
	public float heliumValue = 7;
	public GUIStyle atmosphereStyle;

	private int selectionGridInt = 1;
	private string[] selectionStrings = {"1: Rise", "2: Float", "3: Drop"};

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		if (Input.GetKey ("1")){
			selectionGridInt = 0;
		}else if (Input.GetKey ("2")){
			selectionGridInt = 1;
		}else if (Input.GetKey ("3")){
			selectionGridInt = 2;
		}


	}

	void OnGUI () {

		// Make a background box
		GUI.Box(new Rect(0,Screen.height-230,100,100), "  Atmosphere", atmosphereStyle);
		selectionGridInt = GUI.SelectionGrid (new Rect (5,Screen.height-200, 90, 60), selectionGridInt, selectionStrings, 1);
		if(selectionGridInt == 0){
			varsScript.setAtmosphereSelected (hexaneValue);
		}else if(selectionGridInt == 1){
			varsScript.setAtmosphereSelected (oxygenValue);
		}else if(selectionGridInt == 2){
			varsScript.setAtmosphereSelected (heliumValue);
		}


	}

}
