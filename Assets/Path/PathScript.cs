using UnityEngine;
using System.Collections;

public class PathScript : MonoBehaviour {


	public float speedX = 1;
	public float speedY = 0;
	public float rotateZ = 0;


	Vector2 pathSpeed = new Vector2();

	// Use this for initialization
	void Start () 
	{
		pathSpeed.x = speedX;
		pathSpeed.y = speedY;
		this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y,0);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.name.Contains("enemy"))
		{

			

			if(!other.gameObject.GetComponent<EnemyBehavior>().hasBubble)
			{
				if(other.rigidbody2D.velocity.magnitude < 9)
				other.rigidbody2D.AddForce(pathSpeed);

				other.transform.eulerAngles = new Vector3(0, 0, rotateZ);
				//other.rigidbody2D.drag = 1;
			}

			
		}


	
	}
}
