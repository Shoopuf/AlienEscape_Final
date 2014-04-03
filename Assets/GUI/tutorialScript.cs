using UnityEngine;
using System.Collections;

public class tutorialScript : MonoBehaviour {

	public EnemyBehavior enemy;
	enum TutorialStates {begin, bubbleTrapped,fanUsed, controlAtmosphere};//enum tutorialState{};
	TutorialStates currentState = TutorialStates.begin;
	public GlobalVariables gVars;

	// Use this for initialization
	void Start () {
		this.guiText.text = "Aliens will always walk towards the closest door.\nBut they can be stopped by objects in the way.\n Click on an alien to trap him in a bubble.";
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == TutorialStates.begin && enemy.hasBubble) {
			currentState = TutorialStates.bubbleTrapped;
			this.guiText.text = "Bubbles will pop once they hit the space ship.\nOnce an alien is trapped in a bubble it can be affected by\n wind and atmosphere changes. Press 1,2,3 to control Atmosphere" ;
			}

		if(currentState == TutorialStates.bubbleTrapped && gVars.atmosphereSelected!=0){
			currentState = TutorialStates.controlAtmosphere;
			this.guiText.text = "To win the level, you must get all the aliens to the matching coloured doors.\n You lose if you get the wrong alien to the wrong door.";
		}


		if (currentState == TutorialStates.controlAtmosphere && gVars.win) {
			currentState = TutorialStates.fanUsed;
			this.guiText.text = "Congrats! You Won!\n You can either restart the level, go to the next level,\n or go back to the main menu to select a different level.";
		}
		//enemy.
	}
}
