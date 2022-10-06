using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeCircle : MonoBehaviour
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
        magnitude = dragdirection.GetComponent<ballShot>().dragdirection.magnitude;
        if (magnitude >= 200f)
        {
            magnitude = 200f;
        }
        
        //Debug.Log(magnitude);
        transform.localScale = new Vector2(magnitude* 0.025f,magnitude* 0.025f);
    }

}
