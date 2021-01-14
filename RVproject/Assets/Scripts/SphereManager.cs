using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] Spheres;
    private int index = 0;
    private Color targetcolor = new Color(0, 1, 0, 0.9f);
    private int Counter = -1;
    void Start()
    {

        
    }

    // Update is called once per frame
    public void TargetUpdate()
    {
        Spheres = GameObject.FindGameObjectsWithTag("Ball");
        if (index >= Spheres.Length)
            index = 0;
        Spheres[index].GetComponent<Renderer>().material.color = targetcolor;
        Spheres[index].name = "Target";
        index++;
        Counter++;
    }

    public int getScore()
    {
        return Counter;
    }
}
