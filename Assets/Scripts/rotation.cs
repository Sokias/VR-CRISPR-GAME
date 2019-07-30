using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject pb;
    private float rotate;
    bool isStop = false;
    // Start is called before the first frame update
    void Start()
    {
        rotate = pb.transform.rotation.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(isStop && ((int)transform.rotation.eulerAngles.x==0)))
        {
            pb.transform.Rotate(new Vector3(1f,0f,0f));

        }
        if (Input.GetKey(KeyCode.A))
        {
            isStop = true;
        }
    }

}
