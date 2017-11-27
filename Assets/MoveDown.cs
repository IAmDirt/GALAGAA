using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {
    public float speed;
    Vector2 direction;

    void Start()
        {
        direction = new Vector2(0, -1f);
        }
    void Update()
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = direction * speed;
        }
	
}
