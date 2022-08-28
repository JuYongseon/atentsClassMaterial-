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
        // 1. Translate 함수 사용
        //자식일때는 space.world(전역) space.self(지역)을 표시한다.
        //transform.Translate(1.01f, 0, 0, Space.World);
        //transform.Translate(new Vector3(1.01f, 0, 0), Space.World);

        // 2.
        /*Vector3 tmp = transform.position;
        tmp.x = tmp.x + Time.deltaTime * speed;
        transform.position = tmp;
        */

        //tTranslate함수를 사용하여 특정 방향으로 이동
        //transform.Translate(dir.normalized * Time.deltaTime * speed);

        //좌표를 직접계산하는 방식으로 특정방향으로 이동
        /* Vector3 tmp = transform.position;
         tmp.x = tmp.x + dir.normalized.x * Time.deltaTime * speed;
         tmp.y = tmp.y + dir.normalized.y * Time.deltaTime * speed;
         tmp.z = tmp.z + dir.normalized.z * Time.deltaTime * speed;
         //한번에 벡터로 넣는 법
         //tmp = tmp + dir.normalized * Time.deltaTime * speed;
         transform.position = tmp;
        */

        //원하는 목표지점 까지 이동
        transform.position =
            Vector3.MoveTowards(transform.position, end, Time.deltaTime * speed);
    }
}
