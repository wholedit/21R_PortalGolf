using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skipBtn : MonoBehaviour
{
    public GameObject skipPopup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPopup()
    {
        skipPopup.SetActive(true);
    }
}
