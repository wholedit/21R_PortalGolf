using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("ball"))
        {
            Invoke("InvokeCallRetryPanel", 0.08f);
        }
    }

    void InvokeCallRetryPanel()
    {
        gameManager.gameManagerInstance.callRetryPanel();
    }
}
