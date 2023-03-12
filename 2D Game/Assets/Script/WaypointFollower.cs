using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    private int currentWaypoitnIndex = 0;

    [SerializeField] private float Speed = 2f;

   private void Update()
    {
        if (Vector2.Distance(waypoint[currentWaypoitnIndex].transform.position, transform.position) < .1f)
        {
            currentWaypoitnIndex++;
            if (currentWaypoitnIndex >= waypoint.Length)
            {
                currentWaypoitnIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoint[currentWaypoitnIndex].transform.position, Time.deltaTime* Speed);
    }
}
