using UnityEngine;
using System.Collections;

public class FanScript : MonoBehaviour {


	public float force = 2000;
	//public float torque = 10;

	Vector2 fanForce = new Vector2();
	
	void Start () 
	{
		fanForce.x = force;
		fanForce.y = 0;

	
	}
	


	void OnTriggerEnter2D(Collider2D other)
	{
		other.rigidbody2D.AddForce (fanForce);
		//other.rigidbody2D.AddTorque (torque);
	}

	void OnTriggerStay2D(Collider2D other)
	{

		other.rigidbody2D.AddForce (fanForce);
	}
}
