using UnityEngine;
using System.Collections;

public class fanTutorialScript : MonoBehaviour {

	public EnemyBehavior enemy;
	enum TutorialStates {begin, bubbleTrapped,fanUsed, controlAtmosphere, fanPlaced};//enum tutorialState{};
	TutorialStates currentState = TutorialStates.begin;
	public GlobalVariables gVars;

	// Use this for initialization
	void Start () {
		this.guiText.text = "You can now place your own fans in the level to move aliens trapped in bubbles.\nPress the 'F' button to make a fan appear";
	}
	
	// Update is called once per frame
	void Update () {

		if (currentState == TutorialStates.begin && Input.GetKeyDown (KeyCode.F)) {
			currentState = TutorialStates.fanUsed;
			this.guiText.text = "Click where you would like to place a fan. \nMove your cursor to decide the direction the fan will blow in \nClick to finalize the direction.\n The bubbles show the wind stream.";
		}
		if (currentState == TutorialStates.fanUsed && Input.GetMouseButtonDown(0)) {
			currentState = TutorialStates.fanPlaced;
			this.guiText.text = "You have a limited number of fans per level.\nPlace them carefully!";
		}

		//enemy.
	}
}
