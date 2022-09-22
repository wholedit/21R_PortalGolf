using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalManager : MonoBehaviour
{
    public static portalManager portalManagerInstance;

    [SerializeField]
    private GameObject bluePortal, orangePortal;

    [SerializeField]
    private Transform bluePortalSpawnPoint, orangePortalSpawnPoint;

    private Collider2D bluePortalCollider, orangePortalCollider;

    [SerializeField]
    private GameObject clone;

    

    void Start()
    {
        portalManagerInstance = this;
        bluePortalCollider = bluePortal.GetComponent<Collider2D>();
        orangePortalCollider = orangePortal.GetComponent<Collider2D>();

    }

    public void CreateClone(string whereToCreate)
    {
        if(whereToCreate == "atBlue")
        {
            var instantiateClone = Instantiate(clone, bluePortalSpawnPoint.position, Quaternion.identity);
            instantiateClone.gameObject.name = "clone";
            //instantiateClone.GetComponent<Rigidbody2D>.velocity = 
            
        }

        else if (whereToCreate == "atOrange")
        {
            var instantiateClone = Instantiate(clone, orangePortalSpawnPoint.position, Quaternion.identity);
            instantiateClone.gameObject.name = "clone";
        }
    }
    // no more clone
    public void DisableCollider(string colliderToDisable)
    {
        if(colliderToDisable == "orange")
        {
            orangePortalCollider.enabled = false;
        }
        else if (colliderToDisable == "blue")
        {
            bluePortalCollider.enabled = false;
        }
    }

    public void EnableColliders()
    {
        orangePortalCollider.enabled = true;
        bluePortalCollider.enabled = true;
    }



    /*
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
    */

}
