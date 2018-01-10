using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //public float speed = 5f;
    //public string axis = "Vertical1";
    //public GameObject ball;


    public GameObject enemyType;
    public float timeToSpawn = 20f;
    public float lifeTime = 10f;

    public Vector2 spawnPoint;
    private float timeSinceSpawn = 0f;
    private GameObject instantiatedObject;
    //public Rigidbody2D enemypaddle;

    //private void Awake()
    //{
    //    spawnPoint = GetComponent<Transform>();
    //}

    // Use this for initialization
    private void Start()
    {
        //enemypaddle = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceSpawn += Time.deltaTime;

        if (timeSinceSpawn > timeToSpawn)
        {
            // Spawn an enemy exactly on the spawn point
            Vector2 spawnPosition = new Vector2(Random.Range(-spawnPoint.x, spawnPoint.x), spawnPoint.y);
            instantiatedObject = (GameObject)Instantiate(enemyType, spawnPosition, Quaternion.identity);

            Destroy(instantiatedObject, lifeTime);
            timeSinceSpawn = 0f;
        }
    }

    void FixedUpdate()
    {
        //float target = ball.transform.position.y;
        //float newDistance = (target - this.transform.position.y) / 4.0f;
        //enemypaddle.velocity = new Vector2(0, newDistance) * speed;
    }

}