using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {
	public GlobalVariables varsScript;
	public bool hasBubble = false;
	public float bubbleAdded;
	private float minVelocity = 1;
	public bool collision = true;
	public AudioClip pop;


	// Use this for initialization
	void Start () {
	
	}

	/*
	void FixedUpdate () {
		if(!hasBubble){
			Vector3 velocity = this.rigidbody2D.velocity;
			Vector3 dirOfTravel = new Vector3 (velocity.x, velocity.y, 0);
			Vector3 rot = Vector3.Cross(dirOfTravel, Vector3.forward);
			this.transform.up = rot;
		}


	}
	*/

	// Update is called once per frame
	void LateUpdate () {
		if (this.hasBubble) {
				this.gameObject.rigidbody2D.gravityScale = varsScript.getAtmosphereSelected();
				if(this.gameObject.rigidbody2D.gravityScale == 0){
					this.gameObject.rigidbody2D.drag = 3;
				}
		}

	}

	void OnCollisionEnter2D(Collision2D other){

		Debug.Log (other.gameObject.name);
		if (!hasBubble)
				if (!other.gameObject.CompareTag ("Path") && !other.gameObject.CompareTag ("Ship")) {

						this.rigidbody2D.gravityScale = 0;
						this.gameObject.rigidbody2D.velocity = Vector2.zero;
						this.gameObject.rigidbody2D.drag = 0;

				} 

	}

	void OnCollisionStay2D(Collision2D other){

		if (hasBubble) {
			if (other.gameObject.CompareTag ("Ship") || other.gameObject.CompareTag ("Platform") || other.gameObject.CompareTag ("Enemy"))
			if ((Time.time - bubbleAdded) > 1) {
					hasBubble = false;
					this.rigidbody2D.gravityScale = 0;
					this.gameObject.rigidbody2D.velocity = Vector2.zero;
					this.gameObject.rigidbody2D.drag = 0;
					foreach (Transform child in transform) {
							Debug.Log ("Bubble destroys while on Enemy");
							Destroy (child.gameObject);
							audio.PlayOneShot(pop);
	
					}
			}

		} 
		}


}
