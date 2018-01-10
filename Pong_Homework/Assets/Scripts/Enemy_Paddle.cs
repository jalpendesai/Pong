using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Paddle : MonoBehaviour {

    public float speed = 5f;
    public string axis = "Vertical1";
    public GameObject ball;

    void FixedUpdate()
    {
        float target = ball.transform.position.y;
        float newDistance = (target - this.transform.position.y) / 2.0f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, newDistance) * speed;
    }
}
