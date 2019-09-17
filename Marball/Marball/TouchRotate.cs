using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    public float speed = 2;
    private Vector2 touchDeltaPosition;

    void Update()
    {
        if (Input.touchCount > 0 &&
       Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            // Get movement of the finger since last frame
            touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across Z plane
            transform.Rotate(0,
                        0, touchDeltaPosition.x * speed - touchDeltaPosition.y * speed);
        }
    }
}

