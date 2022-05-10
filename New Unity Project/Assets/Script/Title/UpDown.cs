using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    private float upMax = 5.0f;
    private float downMax = -5.0f;
    private float currentPosition;
    private float firstPosition;
    private float direction = 10.0f;

    void Start()
    {
        currentPosition = transform.position.y;
        firstPosition = transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, currentPosition, transform.position.z);
        currentPosition += Time.deltaTime * direction;

        if (currentPosition > firstPosition + upMax)
        {
            direction *= -1;
            currentPosition = firstPosition + upMax;

        }
        else if (currentPosition < firstPosition + downMax)
        {
            direction *= -1;
            currentPosition = firstPosition + downMax;
        }

    }
}
