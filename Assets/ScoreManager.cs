using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public static int level = 0;
	public static int score;
	public static int levelTwoScore;
	public static int levelFourScore;
	public static int levelFiveScore;
	public static int levelSixScore;
	public static bool reset = true;

	public GameObject levelTwoStarOne;
	public GameObject levelTwoStarTwo;
	public GameObject levelTwoStarThree;

	public GameObject levelFourStarOne;
	public GameObject levelFourStarTwo;
	public GameObject levelFourStarThree;

	public GameObject levelFiveStarOne;
	public GameObject levelFiveStarTwo;
	public GameObject levelFiveStarThree;

	public GameObject levelSixStarOne;
	public GameObject levelSixStarTwo;
	public GameObject levelSixStarThree;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		//update score based on most recently played level
		if (level == 2) {
			levelTwoScore = score;

		}

		if (level == 4) {
			levelFourScore = score;
		}

		if (level == 5) {
			levelFiveScore = score;
		}

		if (level == 6) {
			levelSixScore = score;
		}

		//resets scores if reset button is hit
		if (reset == true) {
			resetScore();
			reset = false;
		}
		DisplayScores ();
			
	}

	void DisplayScores(){
		//Level 2 Score Displays
		if(levelTwoScore == 1){
			Debug.Log ("score: 1");
			levelTwoStarOne.GetComponent<SpriteRenderer>().enabled = true;
			levelTwoStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelTwoScore == 2){
			Debug.Log ("score: 2");
			levelTwoStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarTwo.GetComponent<SpriteRenderer>().enabled = true;
			levelTwoStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelTwoScore == 3){
			Debug.Log ("score: 3");
			levelTwoStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarThree.GetComponent<SpriteRenderer>().enabled = true;
			
		}
		else if(levelTwoScore < 1 || levelTwoScore > 3){
			levelTwoStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelTwoStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}

		//Level 4 Score Displays
		if(levelFourScore == 1){
			Debug.Log ("score: 1");
			levelFourStarOne.GetComponent<SpriteRenderer>().enabled = true;
			levelFourStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelFourScore == 2){
			Debug.Log ("score: 2");
			levelFourStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarTwo.GetComponent<SpriteRenderer>().enabled = true;
			levelFourStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelFourScore == 3){
			Debug.Log ("score: 3");
			levelFourStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarThree.GetComponent<SpriteRenderer>().enabled = true;
			
		}
		else if(levelFourScore < 1 || levelFourScore > 3){
			levelFourStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFourStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}

		//Level 5 Score Displays
		if(levelFiveScore == 1){
			Debug.Log ("score: 1");
			levelFiveStarOne.GetComponent<SpriteRenderer>().enabled = true;
			levelFiveStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelFiveScore == 2){
			Debug.Log ("score: 2");
			levelFiveStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarTwo.GetComponent<SpriteRenderer>().enabled = true;
			levelFiveStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelFiveScore == 3){
			Debug.Log ("score: 3");
			levelFiveStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarThree.GetComponent<SpriteRenderer>().enabled = true;
			
		}
		else if(levelFiveScore < 1 || levelFiveScore > 3){
			levelFiveStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelFiveStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}

		//Level 6 Score Displays
		if(levelSixScore == 1){
			Debug.Log ("score: 1");
			levelSixStarOne.GetComponent<SpriteRenderer>().enabled = true;
			levelSixStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelSixScore == 2){
			Debug.Log ("score: 2");
			levelSixStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarTwo.GetComponent<SpriteRenderer>().enabled = true;
			levelSixStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
		if(levelSixScore == 3){
			Debug.Log ("score: 3");
			levelSixStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarThree.GetComponent<SpriteRenderer>().enabled = true;
			
		}
		else if(levelSixScore < 1 || levelSixScore > 3){
			levelSixStarOne.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarTwo.GetComponent<SpriteRenderer>().enabled = false;
			levelSixStarThree.GetComponent<SpriteRenderer>().enabled = false;
			
		}
	}

	void resetScore(){

		level = 0;
		score = 0;
		levelTwoScore = 0;
		levelFourScore = 0;
		levelFiveScore = 0;
		levelSixScore = 0;
	}


	
}

