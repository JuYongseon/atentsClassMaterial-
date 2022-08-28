using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExample_7_27 : MonoBehaviour
{
    const float speed = 2.5f;
    Vector3 dir;
    Vector3 end;
    // Start is called before the first frame update
    void Start()
    {
        dir = new Vector3(0, 10, 0) - transform.position;

        end = new Vector3(10,10,10);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Translate �Լ� ���
        //�ڽ��϶��� space.world(����) space.self(����)�� ǥ���Ѵ�.
        //transform.Translate(1.01f, 0, 0, Space.World);
        //transform.Translate(new Vector3(1.01f, 0, 0), Space.World);

        // 2.
        /*Vector3 tmp = transform.position;
        tmp.x = tmp.x + Time.deltaTime * speed;
        transform.position = tmp;
        */

        //tTranslate�Լ��� ����Ͽ� Ư�� �������� �̵�
        //transform.Translate(dir.normalized * Time.deltaTime * speed);

        //��ǥ�� ��������ϴ� ������� Ư���������� �̵�
        /* Vector3 tmp = transform.position;
         tmp.x = tmp.x + dir.normalized.x * Time.deltaTime * speed;
         tmp.y = tmp.y + dir.normalized.y * Time.deltaTime * speed;
         tmp.z = tmp.z + dir.normalized.z * Time.deltaTime * speed;
         //�ѹ��� ���ͷ� �ִ� ��
         //tmp = tmp + dir.normalized * Time.deltaTime * speed;
         transform.position = tmp;
        */

        //���ϴ� ��ǥ���� ���� �̵�
        transform.position =
            Vector3.MoveTowards(transform.position, end, Time.deltaTime * speed);
    }
}
