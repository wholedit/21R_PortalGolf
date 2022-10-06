using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowRotate : MonoBehaviour
{
    public GameObject dragdirection;
    float magnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ+90);


        magnitude = dragdirection.GetComponent<ballShot>().dragdirection.magnitude;
        if (magnitude >= 200f)
        {
            magnitude = 200f;
        }
        transform.localScale = new Vector2(magnitude * 0.005f, magnitude * 0.005f);
    }
}
