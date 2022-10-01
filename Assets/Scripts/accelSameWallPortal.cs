using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelSameWallPortal : MonoBehaviour
{
    private Vector2 enterVelocity;
    public GameObject Border;
    public portalManager manager;
    public float accelPower = 1.3f;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            //들어오는 공 속도
            enterVelocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;

            //잠시 벽 끄기
            Border.SetActive(false);
            Debug.Log(enterVelocity);

            if (gameObject.name == "bluePortal")
            {
                // 반대쪽 포탈 콜라이더 죽이고 클론생성하기
                manager.DisableCollider("orange");
                manager.CreateClone("atOrange");
                // 클론 속도주기
                GameObject.Find("clone").GetComponent<Rigidbody2D>().velocity = -enterVelocity * accelPower;

            }

            else if (gameObject.name == "orangePortal")
            {
                manager.DisableCollider("blue");
                manager.CreateClone("atBlue");
                GameObject.Find("clone").GetComponent<Rigidbody2D>().velocity = -enterVelocity * accelPower;

            }

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //다시 벽 켜기
            Border.SetActive(true);

            if (gameObject.name != "clone")
            {
                Destroy(collision.gameObject);
                manager.EnableColliders();
                GameObject.Find("clone").name = "Ball";
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
