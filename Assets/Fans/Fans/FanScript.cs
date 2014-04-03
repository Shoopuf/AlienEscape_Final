using UnityEngine;
using System.Collections;

public class FanScript : MonoBehaviour {

	private float force = 50;
	public Vector2 fanForce = new Vector2();
	public GameObject particles;

	
	void Start () 
	{
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector2 fanLocation = new Vector2 (mousePos.x, mousePos.y);
		GameObject ps = Instantiate (particles, fanLocation, transform.rotation)
			as GameObject;
		ps.transform.parent = this.transform;
		ps.renderer.sortingLayerName = "Forground";
	}

	void OnTriggerEnter2D(Collider2D other)
	{	if(other.gameObject.name.Contains("enemy_")&&other.gameObject.GetComponent<EnemyBehavior>().hasBubble)
		if(other.GetComponent<Rigidbody2D>() != null)
		other.rigidbody2D.AddForce (fanForce);
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.name.Contains("enemy_")&&other.gameObject.GetComponent<EnemyBehavior>().hasBubble)
		if(other.GetComponent<Rigidbody2D> () != null)
		other.rigidbody2D.AddForce (fanForce);
	}


}
