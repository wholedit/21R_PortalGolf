using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class innerCircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("ball"))
        {
            gameManager.gameManagerInstance.life += 1;
            Rigidbody2D ballRB = collision.gameObject.GetComponent<Rigidbody2D>();
            ballRB.velocity = Vector2.zero;

            gameManager.gameManagerInstance.callNextLevelPanel();
        }
        

    }
}
