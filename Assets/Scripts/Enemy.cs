using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
��ǥ: �Ʒ� �������� �̵��Ѵ�.

��ǥ2 : �ٸ� �浹ü�� �ε������� ��, ��븦 �ı��Ѵ�.

��ǥ3 : ���۽� 30%�� Ȯ���� �÷��̾ ���󰣴�.

�ʿ�Ӽ� - 30%�� Ȯ��

��ǥ4 : 10������ Ȯ���� �÷��̾ ���󰣴�.

�ʿ�Ӽ� - �÷��̾��� ����
*/
public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    Vector3 dir = Vector3.down;


    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);

            Destroy(other.gameObject);
        }
    }
}

