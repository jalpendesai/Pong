using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMover : MonoBehaviour {

    float movementSpeed = 0.01f;

    bool runForwards = true;

    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {

        Vector2 oPos = transform.position;
        float calculatedPosition;

        if (runForwards)
        {
            calculatedPosition = oPos.y + movementSpeed;
        }
        else
        {
            calculatedPosition = oPos.y - movementSpeed;
        }

        transform.position = new Vector2(oPos.x , oPos.y + movementSpeed);
    }

    void OnCollsionEnter(Collider collider)
    {
        WallCollisionHandler(collider);
    }

    void WallCollisionHandler(Collider collider)
    {
        if (collider.tag == "Wall")
        {
            runForwards = false;

            // Or
            // JumpBackwards()
        }
        else if (collider.tag == "Wall")
        {
            runForwards = true;

            // Or
            // JumpForwards()
        }
    }
}
