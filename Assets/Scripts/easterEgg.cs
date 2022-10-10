using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easterEgg : MonoBehaviour
{
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ballInvoke", 10f, 10f);
        Invoke("cancelInvoke", 150f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ballInvoke()
    {
        Instantiate(ball);
    }
    void cancelInvoke()
    {
        CancelInvoke("ballInvoke");
    }



}
