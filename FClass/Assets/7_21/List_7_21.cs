using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_7_21 : MonoBehaviour
{
    List<int> list;
    void Start()
    {
        list = new List<int>();
        list.Add(100);
        list.Add(200);
        list.Add(300);
        list.Add(400);
        list.Add(500);
        // list.Count�� ����� ������ ������ �ǹ�
        Debug.Log("����Ʈ�� ����� ������ ���� = " + list.Count);
        //�迭ó�� ��� �� �� �ִ�.
        Debug.Log(list[0]);
        Debug.Log(list[1]);
        Debug.Log(list[2]);
        Debug.Log(list[3]);
        Debug.Log(list[4]);
        //Debug.Log(list[5]);//����Ʈ�� ����� ������ �������� ���� ȣ���ؼ� ������ ��

        //������ �˻�
        //�����Ͱ� 300�� ��带 ã�Ƽ� ���� ���� �޾Ƽ� ����
        //�Ʒ��� ���� ���ٽ� �̶�� �Ѵ�.
        int data = list.Find(o => (o == 300));

        //������ ����
        //�������� ����
        list.Sort((x, y) => x.CompareTo(y));

        //�������� ����
        list.Sort((x, y) => y.CompareTo(x));

        //����Ʈ ���� ����
        list.Insert(0,1000);
        Debug.Log(list[0]);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
