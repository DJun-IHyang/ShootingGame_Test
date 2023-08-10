using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ǥ : �÷��̾ ����� �Է¿� ���� �����̰� �ʹ�.
public class PlayerMove : MonoBehaviour
{

    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = Vector3.right * h + Vector3.up * v;

        transform.Translate(dir * speed * Time.deltaTime);

    }
}