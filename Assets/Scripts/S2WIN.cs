using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2WIN : MonoBehaviour
{
    public static int S2already = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (S2already == 15) SceneManagerScript.SCENE_NUNMBER = 2.1;
    }

}
