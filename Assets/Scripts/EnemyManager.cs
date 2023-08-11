using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
목표: 적을 생성한다

필요속성: 특정 신간, 현재 시간, 적 GameObject

순서1. 현재시간이 흐른다

순서2. 현재 시간이 특정시간이 되면
순서3. 적을 EnemyManager위치에 생성한다.

순서4. 시간을 초기화 해준다.

목표2. 특정 시간을 랜덤한 시간으로 설정한다.
*/
public class EnemyManager : MonoBehaviour
{

    public GameObject enemy;
    float currentTime;
    public float createTime;

    public float minTime;
    public float maxTime;

    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        /*currentTime += Time.deltaTime;*/

        print("currentTime" + currentTime);

        if(currentTime > createTime)
        {

            GameObject enemyGO = Instantiate(enemy);
            enemyGO.transform.position = transform.position;

            //순서4. 시간을 초기화 해준다.
            currentTime = 0;
        }

      

    }
}
