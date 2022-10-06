using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{

    public Material bgMaterial;
    public float scrollSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.up;

        bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
    }
}
