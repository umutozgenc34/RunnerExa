using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cam;

    private Touch touch;

    public float speed;

    public float conSpeed;

    private Rigidbody rb;

    public GameObject vectorBack;
    public GameObject vectorFront;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Datas.firstTouch == 1 )
        {
            transform.position += new Vector3(0, 0, conSpeed * Time.deltaTime);
            cam.transform.position += new Vector3(0, 0, conSpeed * Time.deltaTime);
            vectorBack.transform.position += new Vector3(0, 0, conSpeed * Time.deltaTime);
            vectorFront.transform.position += new Vector3(0, 0, conSpeed * Time.deltaTime);

        }

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Datas.firstTouch = 1;
            }

           else if (touch.phase == TouchPhase.Moved)
            {
                rb.velocity = new Vector3( touch.deltaPosition.x * speed * Time.deltaTime,
                                           transform.position.y,
                                           touch.deltaPosition.y * speed * Time.deltaTime);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
