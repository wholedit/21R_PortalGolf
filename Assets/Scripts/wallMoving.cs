using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMoving : MonoBehaviour
{
    public float movingSpeed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("moving", 5f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void moving()
    {
        transform.position += new Vector3(-movingSpeed, 0, 0);

    }
}
