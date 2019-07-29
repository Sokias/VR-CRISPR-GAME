using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class left_hand_translate : MonoBehaviour
{
    Vector3 pinchStartPosition;
    bool isPinch = false;
    Hand leftHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPinch)
        {
            Vector3 transVec = leftHand.GetPinchPosition() - pinchStartPosition;
            transform.position += transVec;
        }
    }

    public void startPinch()
    {
        isPinch = true;
        List<Hand> hands = new Controller().Frame().Hands;
        leftHand = hands[0];
        if (hands.Count == 2)
        {
            leftHand = hands[1];
        }
        pinchStartPosition = leftHand.GetPinchPosition();
    }

    public void endPinch()
    {
        isPinch = false;
    }
}
