using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour {

    public float Playerhealth;

    void Update() {


        if (Playerhealth < 1)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "BULLET2")
        {
            Playerhealth--;
        }
    }
}
