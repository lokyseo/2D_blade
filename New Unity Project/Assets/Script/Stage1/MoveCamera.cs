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
        waypoints = new Vector3[4];

        waypoints.SetValue(new Vector3(2.7f, 4.2f, 0), 0);
        waypoints.SetValue(new Vector3(14f, 1.7f, 0), 1);
        waypoints.SetValue(new Vector3(27.5f, 1.7f, 0), 2);
        waypoints.SetValue(new Vector3(30.35f, 9.0f, 0), 3);


    }

    void Update()
    {
        curPosition = this.transform.position;

        if(waypointIndex < waypoints.Length)
        {
            float step = speed * Time.deltaTime;

            transform.position =
                Vector3.MoveTowards(curPosition, waypoints[waypointIndex], step);

            if(Vector3.Distance(waypoints[waypointIndex], curPosition) == 0f)
            {
                waypointIndex++;
            }
        }
    }
}
