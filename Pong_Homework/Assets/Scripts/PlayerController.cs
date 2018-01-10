using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
//public class Boundary
//{
//    public float xMin, xMax, yMin, yMax;
//}

public class PlayerController : MonoBehaviour {

    public float speed = 5f;
    //public Boundary boundary;
    public string axis = "Vertical";

    private Rigidbody2D rBody;

    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw(axis);
        rBody.velocity = new Vector2(0, v) * speed;
        //transform.Translate(0f, Input.GetAxis("Vertical1") * speed * Time.deltaTime, 0f);

        rBody.position = new Vector2(rBody.position.x, Mathf.Clamp(rBody.position.y, -3.56f, 3.56f));
    }
}
