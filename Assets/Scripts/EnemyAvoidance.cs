using UnityEngine;

public class EnemyAvoidance : MonoBehaviour
{

	public float distanceMultiplier;
	public float speedMultiplier;

	float xStart;
	float timeOffset;

	void Start()
	{
		xStart = transform.position.x;
		timeOffset = Random.Range(-1f, 1f);
	}
	
	void Update ()
	{
		Vector2 position = transform.position;

		var myTime = Time.time + timeOffset;
		
		position.x = xStart + Mathf.Sin(myTime * speedMultiplier) * distanceMultiplier;
		
		transform.position = position;
	}
}
