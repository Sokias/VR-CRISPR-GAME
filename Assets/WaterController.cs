using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterController : MonoBehaviour
{
    private bool isTriggered = false;
    private bool canDrop = false;
    //the velocity that the ball enlarges
    public float enlargeVelocity = 0.004f;
    //the "gravitational acceleration"
    public float dropAcceleration = -0.23f;
    //the largest size of the ball
    public float maximumBallSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
        // if Leap Motion detects a gesture
        isTriggered = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(this.isTriggered == true)
        {
            enlarge();
            checkSize();
        }
        if(this.canDrop == true)
        {
            drop();
            checkPosition();
        }
    }

    //enlarge the water drop
    void enlarge()
    {
        GameObject.Find("WaterDrop").transform.localScale += new Vector3(enlargeVelocity, enlargeVelocity, enlargeVelocity);
    }

    //check if the size of water drop exceeds the limit (1f scale)
    void checkSize()
    {
        float XScale = GameObject.Find("WaterDrop").transform.localScale.x;
        if (XScale > maximumBallSize)
        {
            //set canDrop variable true
            this.canDrop = true;
        }
    }

    //drop the water
    void drop()
    {
        Rigidbody r = GetComponent<Rigidbody>();
        GameObject Water = GameObject.Find("WaterDrop");
    //Water_X, Water_Y, Water_Z corresponds to the current x, y, z coordinates of Water Drop Object
    float Water_X = Water.transform.position.x;
        float Water_Y = Water.transform.position.y;
        float Water_Z = Water.transform.position.z;

        //drops in -y position
        Vector3 moreVelocity = new Vector3(0, dropAcceleration, 0);
        r.velocity += moreVelocity;
    }

    void checkPosition()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide!");
        GameObject Water = GameObject.Find("WaterDrop");
        Water.SetActive(false);
    }


}
