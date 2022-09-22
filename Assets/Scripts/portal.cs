using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    private Vector2 enterVelocity;    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            
            enterVelocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;

            Debug.Log(enterVelocity);

            if ( gameObject.name == "bluePortal")
            {
                portalManager.portalManagerInstance.DisableCollider("orange");
                portalManager.portalManagerInstance.CreateClone("atOrange");
                
            }

            else if( gameObject.name == "orangePortal")
            {
                portalManager.portalManagerInstance.DisableCollider("blue");
                portalManager.portalManagerInstance.CreateClone("atBlue");
            }

        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {

            if (gameObject.name != "clone")
            {
                Destroy(collision.gameObject);
                portalManager.portalManagerInstance.EnableColliders();
                GameObject.Find("clone").name = "Ball";
            }
        }
    }
//작성중
    public void giveVelocity(GameObject gameObject)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = enterVelocity;
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
