using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.1f, 0, 0);
        if (transform.position.x > 3)
        {
            Destroy(gameObject);
        }
    }
}
