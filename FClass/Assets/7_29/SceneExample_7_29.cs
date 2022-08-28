using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneExample_7_29 : MonoBehaviour
{
    float moveSpeed;

    void Awake()
    {
        moveSpeed = 2.5f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if (x != 0)
            Debug.Log("�������Է°� = " + x);
        if (y != 0)
            Debug.Log("�������Է°� = " + y);

        Vector3 tmp = transform.position;
        tmp.x += x * Time.deltaTime * moveSpeed;
        tmp.y += y * Time.deltaTime * moveSpeed;
        transform.position = tmp;

        //���信 �� �׸���
        Vector3 vStart = Vector3.zero;
        Vector3 vEnd = transform.position;
        Debug.DrawLine(vStart, vEnd, Color.red);

       
    }
}
