using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public static float SCENE_NUMBER = 0;
    public static bool S2Button = false;
    public GameObject screen0;
    public GameObject screen;
    public GameObject screenh;
    public static int segNum;
    public GameObject mega;

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
    public GameObject obj_s3_1;
    public GameObject obj_s3_2;
    public GameObject obj_s4_1;

    public void buildScene()
    {
        switch (SCENE_NUMBER)
        {
            case 0:
                GameObject.Destroy(screen0);
                SCENE_NUMBER = 1;
                changeScreenMaterial_1();
                break;
            case 1.1f:
                SCENE_NUMBER = 2;
                changeScreenMaterial_2();
                // toolbox appear ^
                Invoke("SetActive_2", 5);
                // hand hint appear
                screenh.GetComponent<MeshRenderer>().material = mh_1;
                // main object appear ^
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
                foreach(GameObject go in ButtonBehavior.gos)
                {
                    go.SetActive(false);
                }
                ////
                changeScreenMaterial_3();
                Invoke("SetActive_3", 11);
                screenh.GetComponent<MeshRenderer>().material = mh_2;
                break;
            case 3.1f:
                changeScreenMaterial_4();
                Invoke("mergeDNA", 10f);
                screenh.GetComponent<MeshRenderer>().material = mh_3;
                break;
            case 4:
                changeScreenMaterial_5();
                SCENE_NUMBER = 4.1f;
                //show
                obj_s4_1.SetActive(true);
                //disshow
                obj_s3_1.SetActive(false);
                obj_s3_2.SetActive(false);
                break;
            default:
                break;
        }
    }

    public static int cutNum = 0; //can be 1,4,6,7,8 6=success

    void mergeDNA()
    {
        SCENE_NUMBER = 4;
    }

    void SetActive_2()
    {
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
    }

    void SetActive_3()
    {
        obj_s3_1.SetActive(true);
        obj_s3_2.SetActive(true);
    }

    public Material m1_1;
    public Material m1_2;
    public Material m1_3;
    public Material m1_4;
    public Material m2_1;
    public Material m2_2;
    public Material m2_3;
    public Material m3_1;
    public Material m3_2;
    public Material m4_1;
    public Material m4_2;
    public Material m4_3;
    public Material m5_1;

    public Material mh_1;
    public Material mh_2;
    public Material mh_3;
    public Material mh_4;
    public Material mh_5;
    public Material transp;
    // 4\5 for the result
    //screenh.GetComponent<MeshRenderer>().material = material;

    void changeScreenMaterial_1()
    {
        StartCoroutine(changeMaterialOfScreen(m1_1, 1f));
        StartCoroutine(changeMaterialOfScreen(m1_2, 4f));
        StartCoroutine(changeMaterialOfScreen(m1_3, 6f));
        StartCoroutine(changeMaterialOfScreen(m1_4, 9f));
        Invoke("changeSceneNum_1", 9f);
    }
    void changeSceneNum_1() { SCENE_NUMBER = 1.1f; }

    void changeScreenMaterial_2()
    {
        StartCoroutine(changeMaterialOfScreen(m2_1, 1f));
        StartCoroutine(changeMaterialOfScreen(m2_2, 4f));
        StartCoroutine(changeMaterialOfScreen(m2_3, 6f));
    }

    void changeScreenMaterial_3()
    {
        StartCoroutine(changeMaterialOfScreen(m3_1, 1f));
        StartCoroutine(changeMaterialOfScreen(m3_2, 8f));
    }

    void changeScreenMaterial_4()
    {
        StartCoroutine(changeMaterialOfScreen(m4_1, 1f));
        StartCoroutine(changeMaterialOfScreen(m4_2, 5f));
        StartCoroutine(changeMaterialOfScreen(m4_3, 9f));
    }

    void changeScreenMaterial_5()
    {
        StartCoroutine(changeMaterialOfScreen(m5_1, 1f));
    }

    IEnumerator changeMaterialOfScreen(Material material,float time)
    {
        yield return new WaitForSeconds(time);
        screen.GetComponent<MeshRenderer>().material = material;
    }

}
