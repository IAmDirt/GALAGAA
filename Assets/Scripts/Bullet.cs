using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed;

	public void GetFired(Vector2 direction)
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D>();
		rb.velocity = direction * speed;
	}


	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			GameObject objectWeHit = coll.gameObject;
			Destroy (objectWeHit);
			Destroy (gameObject);
		}

		if (coll.gameObject.tag == "Player") 
		{

		}
	}
}
