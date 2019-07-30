using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public static float SCENE_NUMBER = 0;
    public static bool S2Button = false;
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

    public GameObject obj_s2_1;
    public GameObject obj_s2_2;
    public GameObject obj_s2_3;
    public GameObject obj_s2_4;
    public GameObject obj_s2_5;
    public GameObject obj_s2_6;
    public GameObject obj_s2_7;
    public GameObject obj_s2_8;
    public GameObject obj_s2_9;
    public GameObject obj_s2_10;
    public GameObject obj_s2_11;

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
                // toolbox appear ^
                obj_s2_1.SetActive(true);
                obj_s2_2.SetActive(true);
                obj_s2_3.SetActive(true);
                obj_s2_4.SetActive(true);
                obj_s2_5.SetActive(true);
                obj_s2_6.SetActive(true);
                obj_s2_7.SetActive(true);
                obj_s2_8.SetActive(true);
                obj_s2_9.SetActive(true);
                obj_s2_10.SetActive(true);
                obj_s2_11.SetActive(true);
                S2Button = true;
                // hand hint appear
                // main object appear ^
                break;
            case 2:
                // print("2");
                break;
            case 2.1f:
                // to 3
                SCENE_NUMBER = 3;
                obj_s2_1.SetActive(false);
                obj_s2_2.SetActive(false);
                obj_s2_3.SetActive(false);
                obj_s2_4.SetActive(false);
                obj_s2_5.SetActive(false);
                obj_s2_6.SetActive(false);
                obj_s2_7.SetActive(false);
                obj_s2_8.SetActive(false);
                obj_s2_9.SetActive(false);
                obj_s2_10.SetActive(false);
                obj_s2_11.SetActive(false);
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
        StartCoroutine(changeMaterialOfScreen(m1_2, 6f));
        StartCoroutine(changeMaterialOfScreen(m1_3, 9f));
        StartCoroutine(changeMaterialOfScreen(m1_4, 12f));
        Invoke("changeSceneNum_1", 13f);
    }
    void changeSceneNum_1() { SCENE_NUMBER = 1.1f; }

    void changeScreenMaterial_2()
    {
        StartCoroutine(changeMaterialOfScreen(m2_1, 3f));
        StartCoroutine(changeMaterialOfScreen(m2_2, 8f));
        StartCoroutine(changeMaterialOfScreen(m2_3, 12f));
    }

    IEnumerator changeMaterialOfScreen(Material material,float time)
    {
        yield return new WaitForSeconds(time);
        screen.GetComponent<MeshRenderer>().material = material;
    }

}
