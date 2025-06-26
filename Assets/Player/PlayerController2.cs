using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController2 : MonoBehaviour
{
    Rigidbody2D rbody;
    float axisH = 0.0f;

    void Start()  // ✅ 오타 수정
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        axisH = Input.GetAxis("Horizontal"); // ← 이 코드도 필요할 수 있음
    }

    void FixedUpdate()
    {
        rbody.linearVelocity = new Vector2(axisH * 3.0f, rbody.linearVelocity.y); // ⚠ 'linearVelocity'도 오타입니다.
    }
}
