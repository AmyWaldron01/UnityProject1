using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMover : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int CurWayPointIndex = 0;

    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
         if (Vector2.Distance(waypoints[CurWayPointIndex].transform.position, transform.position) < .1f)
        {
            CurWayPointIndex++;
            if (CurWayPointIndex >= waypoints.Length)
            {
                CurWayPointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[CurWayPointIndex].transform.position, Time.deltaTime * speed);
    }
    
}
