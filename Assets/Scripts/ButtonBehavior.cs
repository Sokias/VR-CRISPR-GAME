using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public static List<GameObject> gos = new List<GameObject>();
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
    Vector3 v = new Vector3(0.5f, 1.4f, 0.7f);
    Quaternion q = new Quaternion();

    public void onPressA()
    {
        if (SceneManagerScript.S2Button) {
            GameObject go = Instantiate(A, v, q);
            gos.Add(go);
        }
    }

    public void onPressC()
    {
        if (SceneManagerScript.S2Button)
        {
            GameObject go = Instantiate(C, v, q);
            gos.Add(go);
        }
    }

    public void onPressG()
    {
        if (SceneManagerScript.S2Button)
        {
            GameObject go = Instantiate(G, v, q);
            gos.Add(go);
        }
    }

    public void onPressU()
    {
        if (SceneManagerScript.S2Button)
        {
            GameObject go = Instantiate(U, v, q);
            gos.Add(go);
        }
    }

}
