using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunker : MonoBehaviour
{
    public float friction = 0.9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Rigidbody2D Rigid = collision.gameObject.GetComponent<Rigidbody2D>();
            Rigid.velocity = new Vector2(Rigid.velocity.x * friction, Rigid.velocity.y * friction);
        }
    }
}
