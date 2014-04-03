using UnityEngine;
using System.Collections;

public class GlobalVariables : MonoBehaviour {
	
	GlobalVariables instance;
	public GlobalVariables Instance { get { if (instance == null)
			instance = this.gameObject.GetComponent<GlobalVariables>();
			return instance; } }
	public GameObject winSprite;
	public GameObject loseSprite;
	private GlobalVariables(){}

	public int numCorrectCatches = 0;
	public int numberOfEnemiesInLevel = 1;
	public bool loose = false;
	public bool win = false;
	public bool playedOnce = false;
	public AudioClip cheer;
	public AudioClip boo;
	public int numFans = 0;
	
	
	public float atmosphereSelected = 1;
	public bool CanPlaceFan = false;
	public bool canPlaceBubble = true;

	void Start () {
		
		
	}
	
	void Update(){
		if (loose == true) {
			loseSprite.GetComponent<SpriteRenderer>().enabled = true;
			Debug.Log ("lose");
			if(playedOnce == false){
				audio.PlayOneShot(boo);
				playedOnce = true;
			}

			
		}else if (numCorrectCatches == numberOfEnemiesInLevel) {
			//sloseSprite.GetComponent<SpriteRenderer>().enabled = true;
			winSprite.GetComponent<SpriteRenderer>().enabled = true;
			win = true;
			if(playedOnce == false){
				audio.PlayOneShot(cheer);
				playedOnce = true;
			}
			
		}
	}
	
	public float getAtmosphereSelected(){
		return atmosphereSelected;
	}
	
	public void setAtmosphereSelected(float newVal){
		atmosphereSelected = newVal;
	}


}
