using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starShooter : MonoBehaviour
{
    public GameObject star;
    public GameObject shootingPoint;
    public float shootingInterval = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makingStar", 0, shootingInterval);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makingStar()
    {
        float x = shootingPoint.transform.position.x;
        float y = shootingPoint.transform.position.y;
        Instantiate(star, new Vector3(x, y, 0), Quaternion.identity);
    }
}
