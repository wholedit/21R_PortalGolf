using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starMoving : MonoBehaviour
{
    public float movingDirection = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.05f * movingDirection, 0, 0);
        if (transform.position.x > 3 || transform.position.x < -3)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        } 
    }
}
