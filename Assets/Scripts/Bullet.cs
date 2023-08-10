using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
/*
목표: 내(총알)가 위로 날아간다.
필요 속성
1. 방향이 필요함
2. 속도가 필요함
*/
public class Bullet : MonoBehaviour
{
    public Vector3 dir = Vector3.up;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;   
    }
}
