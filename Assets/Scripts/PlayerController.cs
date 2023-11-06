using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Touch touch;

    public float speed;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed * Time.deltaTime,
                                                  transform.position.y,
                                                  transform.position.z + touch.deltaPosition.y * speed * Time.deltaTime);
            }
        }
    }
}
