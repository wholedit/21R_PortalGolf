using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleBallMoving : MonoBehaviour
{
    Rigidbody2D myRigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = gameObject.GetComponent<Rigidbody2D>();

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(70, 70));
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.gameManagerInstance.velocity = myRigidBody2D.velocity;
    }
}
