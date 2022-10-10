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

    public float defaultShootPower = 4;
    float shootPower;


    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        shootPower = defaultShootPower;
    }

    // Update is called once per frame
    void Update()
    {
        // velocity에 계속 값을 업데이트해줌
        
        gameManager.gameManagerInstance.velocity = myRigidBody2D.velocity;
        //Debug.Log(gameManager.gameManagerInstance.velocity);

        ballStop();


        if (gameManager.gameManagerInstance.life == 0)
        {
            shootPower = 0f;
        }
        else
        {
            shootPower = defaultShootPower;
        }
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
            Invoke("minusLife", 0.05f);

            endPos = Input.mousePosition;
            direction = startPos - endPos;
            myRigidBody2D.isKinematic = false;
            if (direction.magnitude > 200f)
            {
                direction = direction.normalized * 200f;
            }
            myRigidBody2D.AddForce(direction * shootPower);
            SoundManager.Instance.PlaySFXSound("ballSFX");
            rangeCircle.SetActive(false);
            arrowRotate.SetActive(false);

        }
    }

    void OnMouseDrag()
    {
        if (Input.GetMouseButton(0))
        {
            if (gameManager.gameManagerInstance.life != 0)
            {
                rangeCircle.SetActive(true);
                arrowRotate.SetActive(true);
                // drag 동안 마우스 위치를 추적
                dragPos = Input.mousePosition;
                dragdirection = startPos - dragPos;

            }
        }
    }

    void ballStop()
    {
        if (myRigidBody2D.velocity.x < 0.5f && myRigidBody2D.velocity.x > -0.5f && myRigidBody2D.velocity.y < 0.5f && myRigidBody2D.velocity.y > -0.5f)
        {
                myRigidBody2D.velocity = new Vector2(0, 0);
        }

        if (transform.position.x < -6f || transform.position.x > 6f || transform.position.y < -8f || transform.position.y > 8f)
        {
            myRigidBody2D.velocity = new Vector2(0, 0);
        }
    }

    void minusLife()
    {
        if (gameManager.gameManagerInstance.life != 0)
        gameManager.gameManagerInstance.life -= 1;
        //Debug.Log(gameManager.gameManagerInstance.life);
    }
}
