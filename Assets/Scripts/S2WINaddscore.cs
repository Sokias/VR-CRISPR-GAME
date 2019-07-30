using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S2WINaddscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        S2WIN.S2already += 1;
        //print(S2WIN.S2already);
    }

    public void minScore()
    {
        S2WIN.S2already -= 1;
        //print(S2WIN.S2already);
    }

}
