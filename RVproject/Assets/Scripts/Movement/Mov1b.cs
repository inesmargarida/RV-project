﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov1b : MonoBehaviour {

    public float speed = 2.5f;
    float x, y, z;


    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3 (-1 *(x+Mathf.PingPong(Time.time * speed, 3)), y, z);

    }
    public void setSpeed(float s)
    {
        speed = s;
    }
}
