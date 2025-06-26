using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController2 : MonoBehaviour
{
    Rigidbody2D rbody;
    float axisH = 0.0f;
    public float speed = 3.0f;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        axisH = Input.GetAxis("Horizontal");

        if (axisH > 0.0f)
        {
            // 오른쪽 이동
            Debug.Log("오른쪽 이동");
            transform.localScale = new Vector2(1, transform.localScale.y);
        }
        else if (axisH < 0.0f)
        {
            // 왼쪽 이동
            Debug.Log("왼쪽 이동");
            transform.localScale = new Vector2(-1, transform.localScale.y);
        }
    }

    void FixedUpdate()
    {
        rbody.linearVelocity = new Vector2(speed * axisH, rbody.linearVelocity.y);
    }
}
