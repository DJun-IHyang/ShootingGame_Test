using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
목표: 아래 방향으로 이동한다.

목표2 : 다른 충돌체와 부딪혔으면 나, 상대를 파괴한다.

목표3 : 시작시 30%의 확률로 플레이어를 따라간다.

필요속성 - 30%의 확률

목표4 : 10프로의 확률로 플레이어를 따라간다.

필요속성 - 플레이어의 방향
*/
public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    private void Start()
    {
        randValue = Random.Range(0, 10); // 0 ~ 9 사이의 임의 값
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

