using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuBtn : MonoBehaviour
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

    public void openMenu()
    {
        menuPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
