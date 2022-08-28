using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distanse_7_20 : MonoBehaviour
{
    public GameObject obj_1; //�����Ϳ��� Cube�� ����
    public GameObject obj_2; //�����Ϳ��� Spgere�� ����

    void Start()
    {
        //1. Find�Լ��� ����ؼ� ���ӿ�����Ʈ�� �˻��� �� �ִ�.
        GameObject obj1 = GameObject.Find("Cube");
        GameObject obj2 = GameObject.Find("Sphere");

        float distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        Debug.Log(distance);

        //2. �����ͻ󿡼� ���� �÷��� ���ӿ�����Ʈ�� �����ؼ� ���
        distance = Vector3.Distance(obj_1.transform.position, obj_2.transform.position);
        Debug.Log(distance);
    }

    void Update()
    {
        
    }
}
