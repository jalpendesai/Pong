using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLeft : MonoBehaviour {

    public float speed = 5f;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f,Input.GetAxis("Vertical1") * speed * Time.deltaTime, 0f);
	}
}
