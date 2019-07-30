using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unwinding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void unwindDNASeg(int segNum)
    {
        //Choices of i are confined to 1,4,6,7,8
        SceneManagerScript.cutNum = segNum;
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Segment" + segNum.ToString());
        foreach (GameObject go in gos) {
            for (int i = 0; i < go.transform.childCount; i++)
            {
                if (go.transform.GetChild(i).name=="Sphere")
                {
                    if (go.transform.GetChild(i).transform.position.y > 0)
                    {
                        go.transform.GetChild(i).transform.parent.transform.position += new Vector3(0f, 10f, 0f);
                    }
                    else
                    {
                        go.transform.GetChild(i).transform.parent.transform.position += new Vector3(0f, -10f, 0f);
                    }
                }
            }
        }
        SceneManagerScript.SCENE_NUMBER = 3.1f;
    }
}
