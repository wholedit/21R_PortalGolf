using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bluePortal, orangePortal;

    [SerializeField]
    private Transform bluePortalSpawnPoint, orangePortalSpawnPoint;

    private Collider2D bluePortalCollider, orangePortalCollider;

    [SerializeField]
    private GameObject clone;

    void Start()
    {
        bluePortalCollider = bluePortal.GetComponent<Collider2D>();
        orangePortalCollider = orangePortal.GetComponent<Collider2D>();

    }

    public void CreateClone(string whereToCreate)
    {
        if(whereToCreate == "atBlue")
        {
            var instantiateClone = Instantiate(clone, bluePortalSpawnPoint.position, Quaternion.identity);
            instantiateClone.gameObject.name = "clone";
            
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
}
