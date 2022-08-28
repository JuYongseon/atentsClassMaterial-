using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test_7_27 : MonoBehaviour
{
    Vector3 sV3;
    Vector3 dV3;
    int count = 1;
    float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        sV3 = new Vector3(3, 3, 3);
        dV3 = new Vector3(10, 6, 10);
        transform.position = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1) {
            transform.position = 
                Vector3.MoveTowards(transform.position, dV3, Time.deltaTime * speed);
            if (transform.position == dV3)
                count = 0;
        }
        else
        {
            transform.position =
                Vector3.MoveTowards(transform.position, sV3, Time.deltaTime * speed);
            if (transform.position == sV3)
                count = 1;
        }
        
        //다른학생이 푼거 간결해서 가져옴
        /*transform.position
            = Vector3.MoveTowards(transform.position, purpose, speed * Time.deltaTime);

        if (transform.position == end)
        {
            purpose = start;
        }
        else if (transform.position == start)
        {
            purpose = end;
        }
        */

    }
}
