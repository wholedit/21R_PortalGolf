using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballShot : MonoBehaviour
{


    Vector2 startPos, endPos, dragPos;
    public Vector2 direction;
    public Vector2 dragdirection;
    Rigidbody2D myRigidBody2D;


    //rangeCircle, arrowRotate 변수
    public GameObject rangeCircle;
    public GameObject arrowRotate;
    
    public float shootPower = 10f;



    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // velocity에 계속 값을 업데이트해줌
        
        gameManager.gameManagerInstance.velocity = myRigidBody2D.velocity;

        ballStop();
        // drag 동안 마우스 위치를 추적
        dragPos = Input.mousePosition;
        dragdirection = startPos - dragPos;

    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
    }

    void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            direction = startPos - endPos;
            myRigidBody2D.isKinematic = false;
            if (direction.magnitude > 70f)
            {
                direction = direction.normalized * 70f;
            }
            
            myRigidBody2D.AddForce(direction * shootPower);
            rangeCircle.SetActive(false);
            arrowRotate.SetActive(false);
            Invoke("minusLife", 0.05f);

        }
    }

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            rangeCircle.SetActive(true);
            arrowRotate.SetActive(true);
        }
    }

    void ballStop()
    {
        if (myRigidBody2D.velocity.x < 0.5f && myRigidBody2D.velocity.x > -0.5f && myRigidBody2D.velocity.y < 0.5f && myRigidBody2D.velocity.y > -0.5f)
        {
                myRigidBody2D.velocity = new Vector2(0, 0);
        }
    }

    void minusLife()
    {
        gameManager.gameManagerInstance.life -= 1;
        Debug.Log(gameManager.gameManagerInstance.life);
    }
}
