using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
��ǥ: ���� �����Ѵ�

�ʿ�Ӽ�: Ư�� �Ű�, ���� �ð�, �� GameObject

����1. ����ð��� �帥��

����2. ���� �ð��� Ư���ð��� �Ǹ�
����3. ���� EnemyManager��ġ�� �����Ѵ�.

����4. �ð��� �ʱ�ȭ ���ش�.

��ǥ2. Ư�� �ð��� ������ �ð����� �����Ѵ�.
*/
public class EnemyManager : MonoBehaviour
{

    public GameObject enemy;
    float currentTime;
    public float createTime;

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        print("currentTime" + currentTime);

        if(currentTime > createTime)
        {
            GameObject enemyGO = Instantiate(enemy);
            enemyGO.transform.position = transform.position;

            currentTime = 0;
        }

      

    }
}
