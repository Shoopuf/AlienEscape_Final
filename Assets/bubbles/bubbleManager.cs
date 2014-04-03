using UnityEngine;
using System.Collections;

public class bubbleManager : MonoBehaviour {
	public GameObject BubblePrefab;
	private Vector3 aim;
	public GlobalVariables varsScript;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (varsScript.CanPlaceFan == false && varsScript.canPlaceBubble == true) 
		{
			if (Input.GetMouseButtonDown (0))
					ShootBubble ();
		}

	}
	void ShootBubble(){
		Vector3 mouse = Input.mousePosition;
		this.aim = Camera.main.ScreenToWorldPoint(mouse) + new Vector3(0,0,1);
		GameObject prefab = Instantiate(BubblePrefab,aim, transform.rotation)
			as GameObject;
	}
}
