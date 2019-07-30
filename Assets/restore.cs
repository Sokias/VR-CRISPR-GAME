using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restore : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 v;

    void Start()
    {
        v = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K)) {
            transform.position = v;
        }
    }
}
