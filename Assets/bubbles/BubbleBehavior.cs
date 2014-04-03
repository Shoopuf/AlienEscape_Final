using UnityEngine;
using System.Collections;

public class BubbleBehavior : MonoBehaviour {
	//public GlobalVariables varsScript;
	public GameObject particles;
	public float speed = 20f ;
	public EnemyBehavior enemyScript;
	
	private int timesTriggered = 0;
	private bool hit = false;
	private Vector3 aim;
	private Vector3 initializationPoint;
	// Use this for initialization
	void Start () {
		//varsScript = (GlobalVariables)GetComponent(typeof(GlobalVariables));
		this.aim = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0,0,1);
		this.initializationPoint = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//this.gameObject.rigidbody2D.gravityScale = varsScript.getAtmosphereSelected();

		if (aim == this.transform.position && this.hit == false) {
			GameObject ps = Instantiate (particles, transform.position, transform.rotation)
				as GameObject;
			Destroy(ps, .6f);
			Destroy (this.gameObject);
		} else if(hit == false){
			
			this.transform.position = Vector3.MoveTowards (this.transform.position, aim, Time.deltaTime * speed);
			if(Vector3.Distance(this.initializationPoint, this.transform.position)> 14){
				Destroy(this.gameObject);
				
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)

	{	
		//if(this.transform.parent!=null)
		if (other.gameObject.name.Contains("enemy_")) {
			if (timesTriggered <= 4) {
				timesTriggered++;
				GameObject ps = Instantiate (particles, transform.position, transform.rotation)
					as GameObject;
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
