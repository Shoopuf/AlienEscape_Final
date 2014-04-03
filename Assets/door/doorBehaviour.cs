using UnityEngine;
using System.Collections;

public class doorBehaviour : MonoBehaviour {
	public string colour = "colour";
	public GlobalVariables varsScript;
	public AudioClip sound;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Enemy")) {
			
			if(other.gameObject.name.Contains(colour)){
				varsScript.numCorrectCatches ++;
			}else{
				varsScript.loose = true;
			}
			Destroy(other.gameObject);
			audio.PlayOneShot(sound);
		}
	}
}
