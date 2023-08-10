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

