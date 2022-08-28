using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_7_28 : MonoBehaviour
{
    float speed;
    Vector3 v1;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,10,0);
        speed = Time.deltaTime * 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        example1();
    }
    
    void example1()
    {
        transform.Translate(0,-speed,0);
    }

    void example2()
    {
        v1 = transform.position;
        v1.y -= speed;
        transform.position = v1;
    }
}
