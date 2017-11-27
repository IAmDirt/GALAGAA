using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector2 shootDirection;
	
    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        Vector2 myPosition = transform.position;
        bullet.transform.position = myPosition + shootDirection;
			
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.GetFired(shootDirection);
    }
}