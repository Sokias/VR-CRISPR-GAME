using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public static float SCENE_NUMBER = 0;
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
                SCENE_NUMBER = 1;
                changeScreenMaterial_1();
                break;
            case 1:
                break;
            case 1.1f:
                SCENE_NUMBER = 2;
                changeScreenMaterial_2();
                // toolbox appear
                // hand hint appear
                // main object appear
                break;
            default:
                break;
        }
    }

    public Material m1_1;
    public Material m1_2;
    public Material m1_3;
    public Material m1_4;
    public Material m2_1;
    public Material m2_2;
    public Material m2_3;

    void changeScreenMaterial_1()
    {
        StartCoroutine(changeMaterialOfScreen(m1_1, 3f));
        StartCoroutine(changeMaterialOfScreen(m1_2, 5f));
        StartCoroutine(changeMaterialOfScreen(m1_3, 6f));
        StartCoroutine(changeMaterialOfScreen(m1_4, 5f));
        SCENE_NUMBER = 1.1f;
    }

    void changeScreenMaterial_2()
    {
        StartCoroutine(changeMaterialOfScreen(m2_1, 3f));
        StartCoroutine(changeMaterialOfScreen(m2_2, 5f));
        StartCoroutine(changeMaterialOfScreen(m2_3, 6f));
    }

    IEnumerator changeMaterialOfScreen(Material material,float time)
    {
        yield return new WaitForSeconds(time);
        screen.GetComponent<MeshRenderer>().material = material;
    }

}
