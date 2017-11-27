using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Vector2 positionChange = new Vector2(0, 0);
        
        if (Input.GetKey(KeyCode.W))
        {
            positionChange = new Vector2(0, 1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            positionChange = new Vector2(-1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            positionChange = new Vector2(0, -1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            positionChange = new Vector2(1f, 0);
        }

        Vector2 position = transform.position;
        position = position + (positionChange * Time.deltaTime * speed);
        
        //Clamp position
        position.x = Mathf.Clamp(position.x, -6.25f, 6.25f);
        position.y = Mathf.Clamp(position.y, -4.5f,  -1f);
        
        transform.position = position;
    }
}