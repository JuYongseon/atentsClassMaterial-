using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_7_29 : MonoBehaviour
{
    float elepsed;

    void Awake()
    {
        elepsed = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }
    //1�ʸ��� y������ 1�ʾ� ���� ť��
    void RotateCube()
    {
        elepsed += Time.deltaTime;
        Vector3 tmp = transform.localEulerAngles;
        if (elepsed >= 1f)
        {
            tmp.y += 1f;
            elepsed = elepsed - 1f;
        }
        transform.localEulerAngles = tmp;
    }
}
