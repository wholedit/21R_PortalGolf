using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinning : MonoBehaviour
{
    public float rotateSpeed = 100f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed * Time.deltaTime));
    }
}
