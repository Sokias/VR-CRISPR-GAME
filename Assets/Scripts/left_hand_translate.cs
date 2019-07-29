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
            float transVec = leftHand.transform.position.x - pinchStartPosition;
            transform.position = new Vector3(transform.position.x+transVec*0.2f,transform.position.y,transform.position.z);
        }
    }

    public void startPinch()
    {
        isPinch = true;
        pinchStartPosition = leftHand.transform.position.x;
    }

    public void endPinch()
    {
        isPinch = false;
    }
}
