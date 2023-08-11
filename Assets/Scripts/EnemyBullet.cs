using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
��ǥ: ���Ѿ��� �Ʒ��� ���ư���.
�ʿ� �Ӽ�
1. ������ �ʿ���
2. �ӵ��� �ʿ���
*/
public class EnemyBullet : MonoBehaviour
{
    Vector3 dir = Vector3.down;
    public float speed = 1.0f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        dir = (player.transform.position - gameObject.transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(player != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
