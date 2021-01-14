using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool DepthRay;
    public bool IteratorCursor;

    public bool Stage1;
    public bool Stage2;
    public bool Stage3;
    public bool Stage4;

    public bool ExtraStage110;
    public bool ExtraStage150;
    public bool ExtraStage220;
    public bool ExtraStage300;

    private GameObject Iterator = null, Ray = null;
    private GameObject S1 = null, S2 = null, S3 = null, S4 = null, S110 = null, S150 = null, S220 = null, S300 = null;

    void Start()
    {
        Iterator = GameObject.Find("IteratorCursor");
        Ray = GameObject.Find("DepthRay");

        S1 = GameObject.Find("TestScenes/Stage1");
        S2 = GameObject.Find("TestScenes/Stage2");
        S3 = GameObject.Find("TestScenes/Stage3");
        S4 = GameObject.Find("TestScenes/Stage4");

        S110 = GameObject.Find("ExtraTestScenes/MoreDense110");
        S150 = GameObject.Find("ExtraTestScenes/MoreDense150");
        S220 = GameObject.Find("ExtraTestScenes/MoreDense220");
        S300 = GameObject.Find("ExtraTestScenes/MoreDense300");

        Iterator.SetActive(IteratorCursor);
        Ray.SetActive(DepthRay);

        S1.SetActive(Stage1);
        S2.SetActive(Stage2);
        S3.SetActive(Stage3);
        S4.SetActive(Stage4);

        S110.SetActive(ExtraStage110);
        S150.SetActive(ExtraStage150);
        S220.SetActive(ExtraStage220);
        S300.SetActive(ExtraStage300);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
