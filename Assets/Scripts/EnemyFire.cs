using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*���� �Ѿ� ��� �����

��ǥ5: ���� �÷��̾ ���� Ư�� �ð��� �ѹ��� ���� ���.
�ʿ�Ӽ� : �Ѿ� , Ư���ð�*/
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
