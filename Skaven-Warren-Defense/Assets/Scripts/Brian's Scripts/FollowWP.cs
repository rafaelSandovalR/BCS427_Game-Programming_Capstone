using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    //holds the list of waypoints
    public GameObject[] waypoints;

    //keeps track of the waypoint 
    int currentWP = 0;

    public float speed = 10.0f;
    public float rotSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks the distance between the tank and the waypoint. The waypoint is updated once the tank reaches a certain distance
        if(Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 3)
        {
            currentWP++;
        }

        //
        if(currentWP >= waypoints.Length)
        {
            currentWP = 0;
        }

        //Turns the tank to look at the waypoint and moves the tank
        //this.transform.LookAt(waypoints[currentWP].transform);

        Quaternion lookatWP = Quaternion.LookRotation(waypoints[currentWP].transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookatWP, rotSpeed * Time.deltaTime);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
