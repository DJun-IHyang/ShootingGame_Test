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

            //����4. �ð��� �ʱ�ȭ ���ش�.
            currentTime = 0;
        }

      

    }
}
