using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans_glow : MonoBehaviour
{
    // Start is called before the first frame update
    bool ascend = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = GetComponent<Renderer>().material.color;
        if (ascend)
        {
            c = new Color(c.r, c.g, c.b, c.a + 1);
        }
        else
        {
            c = new Color(c.r, c.g, c.b, c.a - 1);
        }
        if (c.a == 100)
        {
            ascend = false;
        }
        if (c.a == 20)
        {
            ascend = true;
        }
    }
}
