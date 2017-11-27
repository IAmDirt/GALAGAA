using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRegularEnemy : MonoBehaviour {

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public Vector2 spawnDirection;
    public float spawnRate;
    float nextSpawn;

    public float RandomXMin;
    public float RandomXMax;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(RandomXMin, RandomXMax);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate (enemy, whereToSpawn, Quaternion.identity);

  //          MoveDown EnemySpawnScript = enemy.GetComponent<MoveDown>();
 //           EnemySpawnScript.SpawnEnemy(spawnDirection);
        }

	}
}