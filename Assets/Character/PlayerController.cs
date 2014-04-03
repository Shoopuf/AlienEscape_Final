using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject BubblePrefab;
	public GameObject rangeImage;
	public int jumpHeight = 300; 
	public float speed = 70f;
	private bool facingRight = false;
	public bool isGrounded = true;
	Animator animator;
	void Start () {

		//animator = GetComponent<Animator>();
	}

	void FixedUpdate () {
		if (Input.GetMouseButtonDown (0))
			ShootBubble ();

		//walking
		if (Input.GetKey (KeyCode.W) && isGrounded ) {
			this.rigidbody2D.AddForce( Vector3.up* jumpHeight );
			//this.rigidbody2D.velocity = new Vector3(0,jumpHeight,0);

		} else if (Input.GetAxis ("Horizontal") > 0) {
			transform.position += Vector3.right * Time.deltaTime * speed;
			//animator.SetBool ("IsMoving", true);
			if (!facingRight)
					Flip ();				
		} else if (Input.GetAxis ("Horizontal") < 0) {
			transform.position += Vector3.left * Time.deltaTime * speed;
			//animator.SetBool ("IsMoving", true);
			if (facingRight)
					Flip ();
		} else {
			//animator.SetBool ("IsMoving", false);
		}

	}

	//Flip direction of character face
	void Flip (){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}

	void ShootBubble(){
		GameObject prefab;
		if(facingRight)//shoot from front of character
			 prefab = Instantiate(BubblePrefab,transform.position + new Vector3(2,0,0), transform.rotation)
			as GameObject;
		else
			 prefab = Instantiate(BubblePrefab,transform.position + new Vector3(-2,0,0), transform.rotation)
				as GameObject;
	}


	void OnCollisionEnter2D( Collision2D theCollision)
	{

		//check that collisions on the bottom
		if(theCollision.contacts.Length > 0)
		{
			ContactPoint2D contact = theCollision.contacts[0];
			if(Vector2.Dot(contact.normal, Vector2.up) > 0.5)
			{
				isGrounded = true;
			}
		}

	}
	
	void OnCollisionExit2D( Collision2D theCollision)
	{

			isGrounded = false;

	}
	void OnMouseEnter(){
		
		rangeImage.GetComponent<SpriteRenderer> ().enabled = true;
		
	}
	void OnMouseExit(){
		
		rangeImage.GetComponent<SpriteRenderer> ().enabled = false;
		
	}

}
