using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeBtn : MonoBehaviour
{
    public GameObject menuPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void close()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
