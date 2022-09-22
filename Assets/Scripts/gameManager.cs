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
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {


    }
}
