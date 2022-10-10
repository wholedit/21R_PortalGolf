using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    #region Singleton class:GameManager
    public static gameManager gameManagerInstance;

    void Awake()
    {
        if (gameManagerInstance == null )
        {
            gameManagerInstance = this;
        }
    }
    #endregion

    public int life = 1;
    public Vector2 velocity;
    public GameObject retryPanel;
    public GameObject nextLevelPanel;
    public GameObject stagePanel;      

    // Start is called before the first frame update
    void Start()
    {

        retryPanel.SetActive(false);
        nextLevelPanel.SetActive(false);
        Time.timeScale = 1.0f;
        stagePanel.SetActive(true);
        Invoke("setFalseStagePanel", 2.0f);
        
    }

    // Update is called once per frame
    void Update()
    {


        if (life == 0 && velocity.x == 0 && velocity.y == 0)
        {

            callRetryPanel();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    

    public void callRetryPanel()
    {
        retryPanel.SetActive(true);
        Time.timeScale = 0.0f;

    }

    public void callNextLevelPanel()
    {
        nextLevelPanel.SetActive(true);
        Time.timeScale = 0.0f;

    }

    void setFalseStagePanel()
    {
        stagePanel.SetActive(false);
    }

}
