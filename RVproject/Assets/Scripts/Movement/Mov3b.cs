using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov3b : MonoBehaviour{

    public float speed = 2.5f;
    float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //verticall xyz
        transform.position = new Vector3(x + Mathf.PingPong(Time.time * speed, 1) + 1, y + Mathf.PingPong(Time.time * speed, 1) + 1, z + Mathf.PingPong(Time.time * speed, 1) + 1);

    }
    public void setSpeed(float s)
    {
        speed = s;
    }
}
