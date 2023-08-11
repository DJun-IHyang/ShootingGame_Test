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
    int randValue;
    GameObject player;

    private void Start()
    {
        randValue = Random.Range(0, 10); // 0 ~ 9 ������ ���� ��
        player = GameObject.Find("Player");

        if (randValue > 5)
        {
            if(player != null)
            {
                dir = (player.transform.position - gameObject.transform.position).normalized;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (randValue < 2)
        {
            if (player != null)
            {
                dir = (player.transform.position - gameObject.transform.position).normalized;
            }
        }
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

