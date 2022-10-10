using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            Invoke("InvokeSound", 0.01f);

        }
    }

    void InvokeCallRetryPanel()
    {
        gameManager.gameManagerInstance.callRetryPanel();

    }

    void InvokeSound()
    {
        int num = Random.Range(0, 5) + 1;
        string callName = "meow" + num;
        SoundManager.Instance.PlaySFXSound(callName);
    }
}
