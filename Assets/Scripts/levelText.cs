using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class levelText : MonoBehaviour
{
    TextMeshProUGUI font;
    TextMeshProUGUI shadow;

    // Start is called before the first frame update
    void Start()
    {
        font = transform.Find("font").GetComponent<TextMeshProUGUI>();
        shadow = transform.Find("shadow").GetComponent<TextMeshProUGUI>();
        changeText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeText()
    {
        Scene scene = SceneManager.GetActiveScene();
        int sceneNum = scene.buildIndex;
        font.text = "Level" + " "+sceneNum.ToString();
        shadow.text = "Level" +" " +sceneNum.ToString();
    }
}
