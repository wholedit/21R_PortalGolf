using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakePortal : MonoBehaviour
{
    public GameObject spike;
    // Start is called before the first frame update
    void Start()
    {
        spike.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            spike.SetActive(true);
        }
    }
}
