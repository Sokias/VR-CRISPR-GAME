using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject A;
    public GameObject C;
    public GameObject G;
    public GameObject U;
    Vector3 v = new Vector3(0, 1.4f, 1);
    Quaternion q = new Quaternion();

    public void onPressA()
    {
        if (SceneManagerScript.S2Button) Instantiate(A, v, q);
    }

    public void onPressC()
    {
        if (SceneManagerScript.S2Button) Instantiate(C, v, q);
    }

    public void onPressG()
    {
        if (SceneManagerScript.S2Button) Instantiate(G, v, q);
    }

    public void onPressU()
    {
        if (SceneManagerScript.S2Button) Instantiate(U, v, q);
    }

}
