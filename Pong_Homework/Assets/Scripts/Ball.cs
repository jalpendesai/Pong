using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 5f; 
	// Use this for initialization
	void Start () {
        LaunchBall();
    }


	// Update is called once per frame
	void Update () {
		if(transform.position.x < -10f)
        {
            StartCoroutine(Pause());
        }

        if (transform.position.x > 10f)
        {
            StartCoroutine(Pause());
        }
    }

    void LaunchBall()
    {
        transform.position = Vector2.zero;
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * sx, speed * sy);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2.5f);
        LaunchBall();
    }
}
