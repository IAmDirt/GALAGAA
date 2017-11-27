using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {

    public float enemyHp;

    void Update()
    {


        if (enemyHp < 1)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "BULLET")
        {
            enemyHp--;
        }
    }
}
