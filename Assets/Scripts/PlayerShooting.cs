using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public Gun gun;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			gun.Shoot();
		}
	}
}