using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalManager : MonoBehaviour
{
    private Transform destination;

    public bool isOrange;
    public float distance = 0.2f;



    // Start is called before the first frame update
    void Start()
    {
        if (isOrange == false)
        {
            destination = GameObject.FindGameObjectWithTag("orangePortal").GetComponent<Transform>();
        } 
        else
        {
            destination = GameObject.FindGameObjectWithTag("bluePortal").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ( Vector2.Distance(transform.position, collision.transform.position) > distance )
        {
            collision.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }

}
