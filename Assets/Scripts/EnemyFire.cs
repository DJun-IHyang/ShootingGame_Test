using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*적이 총알 쏘게 만들기

목표5: 적도 플레이어를 향해 특정 시간에 한번씩 총을 쏜다.
필요속성 : 총알 , 특정시간*/
public class EnemyFire : MonoBehaviour
{
    public GameObject enemyBullet;
    float currentTime;
    public float createTime = 1;


    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;


        if (currentTime > createTime)
        {
            GameObject enemyBulletGO = Instantiate(enemyBullet);

            enemyBulletGO.transform.position = transform.position;

            currentTime = 0;
        }

    }
}
