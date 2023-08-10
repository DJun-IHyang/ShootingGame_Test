using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
목표: 사용자 입력(스페이스바)를 받아 총알을 만든다.
순서
1. 입력을 받고싶다.
2. 총알을 만들고 싶다.
*/
public class PlayerFire : MonoBehaviour
{
    public GameObject Bullet;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject BulletGO = Instantiate(Bullet);
            BulletGO.transform.position = transform.position;
        }
    }
}
