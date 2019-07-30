using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yCube1 : MonoBehaviour
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
        rotation.isTriggerEntered = true;
        Invoke("diaoyong", 4);
    }

    void diaoyong()
    {
        Unwinding.unwindDNASeg(1);
    }

    IEnumerator timingUnwind(int index, float time)
    {
        yield return new WaitForSeconds(time); print("success");

        Unwinding.unwindDNASeg(index);
    }

}
