using UnityEngine;
using System.Collections;

public class IntroductionScript : MonoBehaviour {
	public GameObject Text1, Text2, Text3, Text4;
	public GameObject alienSprite, doorSprite, bubble, fan;
	enum TutorialStates {first, second, third};//enum tutorialState{};
	TutorialStates currentState = TutorialStates.first;
	Vector3 toPos;
	Vector3 fromPos;
	float time;
	// Use this for initialization
	void Start () {
		Text1.SetActive(true);
		toPos = alienSprite.transform.position+new Vector3(7,0,0);
		fromPos = alienSprite.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (currentState == TutorialStates.first) {
			if(alienSprite.transform.position != toPos){
				float step = 1.5f * Time.deltaTime;
			
				// Move our position a step closer to the target.
				alienSprite.transform.position = Vector3.MoveTowards(alienSprite.transform.position, toPos, step);
			}else{
				alienSprite.transform.position = fromPos;
				currentState = TutorialStates.second;
				Text1.SetActive(false);
				Text2.SetActive(true);
			}
		}else if (TutorialStates.second == currentState){
			if(alienSprite.transform.position != toPos){
				doorSprite.SetActive(true);
				float step = 1.5f * Time.deltaTime;
				
				// Move our position a step closer to the target.
				alienSprite.transform.position = Vector3.MoveTowards(alienSprite.transform.position, toPos, step);
			}else{
				currentState = TutorialStates.third;
				Text2.SetActive(false);
				Text3.SetActive(true);
				bubble.SetActive(true);
				doorSprite.SetActive(false);
				fan.SetActive(true);
				 toPos = alienSprite.transform.position+new Vector3(7,0,0);
				time = Time.time;
			}
		}else if(currentState == TutorialStates.third){
		
			if(Time.time - time >2){
				if(alienSprite.transform.position != toPos){
				
					float step = 1.5f * Time.deltaTime;
					
					// Move our position a step closer to the target.
					alienSprite.transform.position = Vector3.MoveTowards(alienSprite.transform.position, toPos, step);
					bubble.transform.position = Vector3.MoveTowards(bubble.transform.position, toPos, step);
				}else{
					Application.LoadLevel(0);
				}
			}

		}

		
	}



}
