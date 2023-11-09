using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounds : MonoBehaviour
{
    public Transform vectorLeft;
    public Transform vectorRight;
    public Transform vectorBack;
    public Transform vectorFront;

    void Start()
    {
        
    }

    public void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, vectorLeft.transform.position.x, vectorRight.transform.position.x);
        viewPos.z = Mathf.Clamp(viewPos.z, vectorBack.transform.position.z, vectorFront.transform.position.z);
        transform.position = viewPos;
    }

}
