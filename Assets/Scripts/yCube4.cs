using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yCube4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider c)
    {
        Unwinding.unwindDNASeg(4);
    }

}
