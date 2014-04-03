using UnityEngine;
using System.Collections;

public class BubbleBehavior_withoutPlayer : MonoBehaviour {
	//public GlobalVariables varsScript;
	public GameObject particles;
	public EnemyBehavior enemyScript;
	
	private int timesTriggered = 0;
	public float bubbleAdded;
	private bool hit = false;
	private Vector3 aim;

	// Use this for initialization
	void Start () {
		bubbleAdded = Time.time;
		//varsScript = (GlobalVariables)GetComponent(typeof(GlobalVariables));
		this.aim = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,1);

	}
	
	// Update is called once per frame
	void Update () {

		//this.gameObject.rigidbody2D.gravityScale = varsScript.getAtmosphereSelected();
		if ((Time.time-bubbleAdded)>1&& this.hit == false) {
			this.hit = true;
						GameObject ps = Instantiate (particles, transform.position, transform.rotation)
								as GameObject;
				ps.renderer.sortingLayerName = "Forground";
				Destroy (ps, 1);
				Destroy (this.gameObject);
		} 
	}
	
	void OnTriggerStay2D(Collider2D other)

	{	
		//if(this.transform.parent!=null)

		if (other.gameObject.name.Contains("enemy_")&&this.gameObject.transform.parent == null) {
			if (timesTriggered <= 2) {
				timesTriggered++;
				GameObject ps = Instantiate (particles, transform.position, transform.rotation)
					as GameObject;
				
				ps.renderer.sortingLayerName = "Forground";
				enemyScript = other.gameObject.GetComponent<EnemyBehavior>();
				Destroy(ps, .6f);
				
			}else{
				//only add bubble if there isn't already one
				if(!(enemyScript.hasBubble)){
					//this.transform.position = other.transform.position;
				
					Destroy(this.gameObject.GetComponent<Rigidbody2D>());
					this.transform.parent = other.transform;
					this.transform.localPosition = Vector3.zero;
					hit = true;
					enemyScript.hasBubble = true;
					enemyScript.bubbleAdded = Time.time;
					
				}
			}
		}
		
	}
	
}
