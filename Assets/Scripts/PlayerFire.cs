using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
��ǥ: ����� �Է�(�����̽���)�� �޾� �Ѿ��� �����.
����
1. �Է��� �ް�ʹ�.
2. �Ѿ��� ����� �ʹ�.
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
