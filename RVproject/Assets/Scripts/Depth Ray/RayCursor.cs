using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCursor : MonoBehaviour
{

    public AudioClip hapticSelect;

    static Color s_UnityHighlight = Color.yellow;
    float rSpeed = 0.5f;
    static Color s_UnityCyan = new Color(0.019f, 0.733f, 0.827f, 0.5f);
    GameObject nearestBall;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.parent.position;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - transform.parent.localScale.y + 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Ball") && other.gameObject.name == "Target")
        {
            
            other.gameObject.GetComponent<Renderer>().material.color = s_UnityHighlight;
            nearestBall = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Ball") && other.gameObject.name == "Target")
        {
            Debug.Log("here");
            
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            nearestBall = null;
        }
    }

    public void OnTriggerSelect()
    {
        if (nearestBall.name == "Target")
        {
            Destroy(nearestBall);
            nearestBall = null;
            GameObject.Find("SphereManager").GetComponent<SphereManager>().TargetUpdate();
        }
    }

    public void ChangePosition(Vector2 axis2d)
    {
        Vector3 movement = new Vector3(0.0f, 1.0f, 0.0f);
        
        if (axis2d.y > 0.1f)
            transform.Translate(rSpeed * movement.normalized * axis2d.x, transform.parent);
        else if (axis2d.y < -0.1f)
            transform.Translate(rSpeed * movement.normalized * axis2d.x, transform.parent);

    }
}