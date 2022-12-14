using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    private Vector2 enterVelocity;
    public GameObject Border;
    public portalManager manager;
    public float outDirection = 1f;
    public float accelPower = 1f;

    public BoxCollider2D[] cols;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            //들어오는 공 속도
            enterVelocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;

            //잠시 벽collider 끄기
            cols = Border.GetComponentsInChildren<BoxCollider2D>();
            foreach (BoxCollider2D col in cols)
            {
                col.enabled = false;
            }

            if ( gameObject.name == "bluePortal")
            {
                // 반대쪽 포탈 콜라이더 죽이고 클론생성하기
                manager.DisableCollider("orange");
                manager.CreateClone("atOrange");

                SoundManager.Instance.PlaySFXSound("warp");


                // 클론 속도주기
                GameObject.Find("clone").GetComponent<Rigidbody2D>().velocity = enterVelocity * outDirection * accelPower;
                
            }

            else if( gameObject.name == "orangePortal")
            {
                manager.DisableCollider("blue");
                manager.CreateClone("atBlue");

                SoundManager.Instance.PlaySFXSound("warp");


                GameObject.Find("clone").GetComponent<Rigidbody2D>().velocity = enterVelocity * outDirection * accelPower;

            }

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            //다시 벽 켜기
            cols = Border.GetComponentsInChildren<BoxCollider2D>();
            foreach (BoxCollider2D col in cols)
            {
                col.enabled = true;
            }

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
