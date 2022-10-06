using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBlink : MonoBehaviour
{
    public float delayTime = 3.0f;
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blink());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Blink()
    {
        while(true)
        {
            wall.SetActive(false);
            yield return new WaitForSeconds(delayTime);
            wall.SetActive(true);
            yield return new WaitForSeconds(delayTime);
        }
        
    }
}
