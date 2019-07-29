using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public static int SCENE_NUMBER = 0;
    public GameObject screen0;
    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buildScene()
    {
        switch (SCENE_NUMBER)
        {
            case 0:
                GameObject.Destroy(screen0);
                changeScreenMaterial_1();
                SCENE_NUMBER = 1;
                break;
            default:
                break;
        }
    }

    public Material m1_1;
    public Material m1_2;
    public Material m1_3;
    public Material m1_4;
    void changeScreenMaterial_1()
    {
        StartCoroutine(changeMaterialOfScreen(m1_1, 3f));
        StartCoroutine(changeMaterialOfScreen(m1_2, 5f));
        StartCoroutine(changeMaterialOfScreen(m1_3, 6f));
        StartCoroutine(changeMaterialOfScreen(m1_4, 5f));
    }

    IEnumerator changeMaterialOfScreen(Material material,float time)
    {
        yield return new WaitForSeconds(time);
        screen.GetComponent<MeshRenderer>().material = material;
    }

}
