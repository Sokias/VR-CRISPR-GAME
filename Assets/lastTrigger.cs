using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Material fail_fail;
    public Material success_fail;
    public Material lastthing;
    public GameObject screen;
    public GameObject screenh;

    private void OnTriggerEnter(Collider other)
    {
        screen.GetComponent<MeshRenderer>().material = lastthing;
        if (SceneManagerScript.cutNum == 6)
        {
            screenh.GetComponent<MeshRenderer>().material = success_fail;
        }
        else
        {
            screenh.GetComponent<MeshRenderer>().material = fail_fail;
        }
    }
}
