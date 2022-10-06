using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMoving : MonoBehaviour
{
    public float movingSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * movingSpeed);
    }
}
