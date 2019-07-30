using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class left_hand_translate : MonoBehaviour
{
    float pinchStartPosition;
    bool isPinch = false;
    public GameObject leftHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPinch)
        {
            float transVec = leftHand.transform.GetChild(0).position.x - pinchStartPosition;
            // print("1:"+ leftHand.transform.position.x);
            // print("2:"+ transVec);
            transform.position = new Vector3(transform.position.x+transVec*0.2f,transform.position.y,transform.position.z);
            // print("3:"+ transform.position);
        }
    }

    public void startPinch()
    {
        isPinch = true;
        //print(isPinch);
        //Unwinding.unwindDNASeg(6);
        pinchStartPosition = leftHand.transform.GetChild(0).position.x;
    }

    public void endPinch()
    {
        isPinch = false;
        //print(isPinch);
    }
}
