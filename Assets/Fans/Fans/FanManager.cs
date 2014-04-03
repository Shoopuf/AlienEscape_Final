using UnityEngine;
using System.Collections;

public class FanManager : MonoBehaviour {

	public GlobalVariables vScript;
	public GameObject fanPrefab;
	public Transform fanSprite;
	private GameObject newFan;
	private bool spriteRotated = false;
	private bool fanRotate = false;
	private Vector2 force;
	// Use this for initialization
	void Start () {
		//vScript.CanPlaceFan = false;
	}

	void Update(){
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
	
		if (Input.GetKey (KeyCode.F)) {
			if(vScript.CanPlaceFan = true && vScript.numFans > 0){
				vScript.CanPlaceFan =true;
				vScript.canPlaceBubble =false;

		}
		else{
			vScript.CanPlaceFan =false;
			vScript.canPlaceBubble=true;
		}
		}

			



		if (Input.GetMouseButtonDown (0) && fanRotate) {
			fanRotate = false; 
			newFan.gameObject.GetComponent<FanScript>().fanForce = force;
			vScript.canPlaceBubble=true;
		}else if(fanRotate){
			float yRotate = (mousePos.y - newFan.transform.position.y);
			float xRotate = (mousePos.x - newFan.transform.position.x);
			float zRotation= Mathf.Atan2(yRotate, xRotate)*Mathf.Rad2Deg;
			newFan.transform.eulerAngles = new Vector3 (0, 0, zRotation);
			Debug.Log (zRotation);
			if(xRotate == 0 && yRotate == 0){
				xRotate = 1;
			}
			force = (new Vector2(xRotate,yRotate)).normalized*1000;
		}
		if (vScript.CanPlaceFan == true) {
			fanSprite.transform.position = new Vector3 (mousePos.x, mousePos.y, fanSprite.transform.position.z);
			fanSprite.renderer.enabled = true;
		}
		if (Input.GetMouseButtonDown (0)&&vScript.CanPlaceFan ==true) {
			vScript.CanPlaceFan = false;
			fanRotate = true;
			fanSprite.renderer.enabled = false;
			newFan = (GameObject)Instantiate (fanPrefab, fanSprite.transform.position, transform.rotation);
			vScript.numFans--;
			
		}
	}
}
