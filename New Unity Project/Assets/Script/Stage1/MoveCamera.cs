using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3[] waypoints;
    private Vector3 curPosition;
    private int waypointIndex;
    private float speed = 1.0f;

    void Start()
    {
        waypoints = new Vector3[3];

    }

    void Update()
    {
        
    }
}
