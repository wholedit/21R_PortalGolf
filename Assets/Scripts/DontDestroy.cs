using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy Instance;

    private float timeStart;
    private float timeCurrent;
    private float adTimer = 0f;
    public bool canGiveAd = true;
    private void Awake()
    {

        if(Instance == null)
        {
            Instance = this;
        }

        var obj = FindObjectsOfType<DontDestroy>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Invoke("frameFix", 0.1f);

    }

    // Start is called before the first frame update
    void Start()
    {
        Reset_Timer();
    }

    // Update is called once per frame
    void Update()
    {

        Check_Timer();
        // 광고 본 후 120초 후에 광고 볼 수 있도록 조건 부여(skip제외)
        if ( canGiveAd == false )
        {
            adTimer += Time.deltaTime;
            if ( adTimer > 120f )
            {
                canGiveAd = true;
                adTimer = 0f;
            }
        }
    }

    private void Check_Timer()
    {
        timeCurrent = Time.time - timeStart;
    }

    private void Reset_Timer()
    {
        timeStart = Time.time;
        timeCurrent = 0;
    }

    private void frameFix()
    {
        Application.targetFrameRate = 40;

    }
}
