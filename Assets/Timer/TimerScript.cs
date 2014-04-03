using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	public GlobalVariables globalVars;
	public GUIStyle style;
	public float mytimer = 0f;
	bool gameOn = true;

	public int threshold3 = 21;
	public int threshold2 = 26;
	public int threshold1 = 33;
	public GameObject starone;
	public GameObject startwo;
	public GameObject starthree;
	public int level = 0;
	public int score = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (globalVars.win != true && globalVars.loose != true) {

			mytimer += Time.deltaTime;
						/*
			if (mytimer > 0) 
			{
				mytimer -= Time.deltaTime;
			}
			if ((int)mytimer == 0)
			{	

				gameOn = false;
			}
			*/
		} 
		else if (globalVars.win == true) {
			StartCoroutine(Show());

			mytimer = mytimer;
		}
	
	}

	IEnumerator Show () {
		
		if (mytimer<=threshold3){
			yield return new WaitForSeconds (1);
			starthree.GetComponent<SpriteRenderer>().enabled = true;
			ScoreManager.level = level;
			score = 3;
			ScoreManager.score = score;
			if(level == 2)
			{
				ScoreManager.levelTwoScore = 3;
			}
			if(level == 4)
			{
				ScoreManager.levelFourScore = 3;
			}
			if(level == 5)
			{
				ScoreManager.levelFiveScore = 3;
			}
			if(level == 6)
			{
				ScoreManager.levelSixScore = 3;
			}
			//give 2 options "restart level or go to level selection"
		}
		else if(mytimer<=threshold2 && mytimer>threshold3){
			yield return new WaitForSeconds (1);
			startwo.GetComponent<SpriteRenderer>().enabled = true;
			ScoreManager.level = level;
			score = 2;
			ScoreManager.score = score;
			ScoreManager.score = score;
			if(level == 2)
			{
				ScoreManager.levelTwoScore = 2;
			}
			if(level == 4)
			{
				ScoreManager.levelFourScore = 2;
			}
			if(level == 5)
			{
				ScoreManager.levelFiveScore = 2;
			}
			if(level == 6)
			{
				ScoreManager.levelSixScore = 2;
			}
			//update the loading screen script so that it reflects the updated high score
			//2 stars awarded
			//give 2 options "restart level or go to level selection"
		}
		else{
			yield return new WaitForSeconds (1);
			starone.GetComponent<SpriteRenderer>().enabled = true;
			ScoreManager.level = level;
			score = 1;
			ScoreManager.score = score;
			ScoreManager.score = score;
			if(level == 2)
			{
				ScoreManager.levelTwoScore = 1;
			}
			if(level == 4)
			{
				ScoreManager.levelFourScore = 1;
			}
			if(level == 5)
			{
				ScoreManager.levelFiveScore = 1;
			}
			if(level == 6)
			{
				ScoreManager.levelSixScore = 1;
			}
		}
		//update the loading screen script so that it reflects the updated high score
		//1 star awarded
		//give 2 options "restart level or go to level selection"
	}

	void OnGUI(){
		int displayTimer = (int)mytimer;
		if (gameOn == true) {
			GUI.Label (new Rect (5, Screen.height-100, 100, 30), (displayTimer.ToString() + " seconds"),style);

		} 
		else {
			globalVars.loose = true;
			//GUI.Label(new Rect(250, 100, 300, 100), (""));	
		}

	}
}
