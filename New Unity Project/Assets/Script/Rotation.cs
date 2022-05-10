using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private int turnSpeed = 360;

    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
    }
}
