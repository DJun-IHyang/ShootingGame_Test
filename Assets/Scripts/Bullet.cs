using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
/*
��ǥ: ��(�Ѿ�)�� ���� ���ư���.
�ʿ� �Ӽ�
1. ������ �ʿ���
2. �ӵ��� �ʿ���
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
