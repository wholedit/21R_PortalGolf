using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallReflect : MonoBehaviour
{
    // �ݻ�Ǵ� ���� ���, a ���� ����, n ���� ����, b ������ ����
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
        // �� �浹�� �� �ݻ�
        if(collision.gameObject.CompareTag("ball"))
        {
            Rigidbody2D ballRB = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 velocity = collision.gameObject.GetComponent<ballShot>().velocity;
            ballRB.velocity = calculateWallReflect(velocity, -collision.GetContact(0).normal);
        }
    }
}
