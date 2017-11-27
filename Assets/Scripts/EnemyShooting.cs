using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
	public Gun gun;
	public float timeBetweenShots;

	float timeOfLastShot;
	
	void Update ()
	{
		var timeSinceLastShot = Time.time - timeOfLastShot;

		if (timeSinceLastShot > timeBetweenShots)
		{
			gun.Shoot();
			timeOfLastShot = Time.time;
		}
	}
}
