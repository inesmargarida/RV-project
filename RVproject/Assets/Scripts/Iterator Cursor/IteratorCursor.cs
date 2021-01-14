﻿using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IteratorCursor : MonoBehaviour
{

    public Transform hand_pos;
    public Material BallColor;
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.8f);
    public GameObject Bubbleprefab;
    private GameObject Bubble;
    private int offset = 0;

    private GameObject nearestBall = null;
    private List<GameObject> CurrentBalls = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        transform.position = hand_pos.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + transform.localScale.y);
        transform.parent = hand_pos;

        Vector3 position = new Vector3(0, 0, 0);
        Quaternion rotation = new Quaternion(1, 1, 1, 1);
        Bubble = Instantiate(Bubbleprefab, position, rotation) as GameObject;
        Bubble.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        CreateBubble();
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.CompareTag("Ball") && other.gameObject.name != "Target")
        {
           
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityCyan;
            CurrentBalls.Add(other.gameObject);
            offset = 0;
        }
        else if (other.gameObject.CompareTag("Ball") && other.gameObject.name == "Target")
        {
           
            CurrentBalls.Add(other.gameObject);
            offset = 0;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Ball") && other.gameObject.name != "Target")
        {
            
            other.gameObject.GetComponent<Renderer>().material.color = BallColor.color;
            CurrentBalls.Remove(other.gameObject);
            offset = 0;
        }
        else if (other.gameObject.CompareTag("Ball") && other.gameObject.name == "Target")
        {
    
            CurrentBalls.Remove(other.gameObject);
            offset = 0;
        }
    }


    public void OnTriggerSelect()
    {

        if (nearestBall.name == "Target")
        {
            CurrentBalls.Remove(nearestBall);
            Destroy(nearestBall);
            nearestBall = null;
            Bubble.SetActive(false);
            offset = 0;
            GameObject.Find("SphereManager").GetComponent<SphereManager>().TargetUpdate();
        }

    }

    public void ChangeBubble()
    {
        if (CurrentBalls.Count > 1)
        {
            if (offset < CurrentBalls.Count - 1)
            {
                offset++;
            }
            else if (offset == CurrentBalls.Count - 1)
            {
                offset = 0;
            }
        }
    }

    void CreateBubble()
    {
        if (CurrentBalls.Count != 0)
        {
            //if (CurrentBalls.Count == offset + 1) offset = 0;
            nearestBall = CurrentBalls.ElementAt(offset);
            Bubble.SetActive(true);
            Bubble.transform.position = nearestBall.transform.position;
        }
        else
        {
            Bubble.SetActive(false);
            nearestBall = null;
        }
    }
}