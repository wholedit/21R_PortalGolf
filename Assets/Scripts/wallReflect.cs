using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallReflect : MonoBehaviour
{
    // 반사되는 벡터 계산, a 공의 벡터, n 법선 벡터, b 나오는 벡터
    Vector2 calculateWallReflect(Vector2 a, Vector2 n)
    {
        Vector2 p = -Vector2.Dot(a, n) / n.magnitude * n / n.magnitude;
        Vector2 b = a + 2*p;
        return b;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 벽 충돌시 공 반사
        if(collision.gameObject.CompareTag("ball"))
        {
            Rigidbody2D ballRB = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 velocity = gameManager.gameManagerInstance.velocity;
            ballRB.velocity = calculateWallReflect(velocity, -collision.GetContact(0).normal);
        }
    }
}
