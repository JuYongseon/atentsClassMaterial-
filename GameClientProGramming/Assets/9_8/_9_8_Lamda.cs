using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ȯ������ int�̰� �Ű������� ������ ��������Ʈ ����
//public delegate int Do(int _a); Do��� ����Ҽ� ���� ������ ��� Do��� ����ϰ� �־(Ŭ������ ����������)
public delegate int Lamda1(int _a);
public delegate int Lamda2();
public delegate void Lamda3();

public class _9_8_Lamda : MonoBehaviour
{
    int i;

    Lamda1 doSomething1;
    Lamda2 doSomething2;
    Lamda3 doSomething3;
    //�����ذ�
    Lamda3 ToDo;
    // Start is called before the first frame update
    void Start()
    {
        //���ٽ��� �̿��Ͽ� �Լ��� �����ϰ� ����
        doSomething1 = (x) => x * x;
        doSomething2 = () => 2 * 2;
        doSomething3 = () => Debug.Log("hi");
        doSomething3 = () => i = 2 * 2;
        //doSomething�� ���ٽ����� ������ �Լ��� ������ ����
        int result = doSomething1(4);
        Debug.Log("���1 = " + result);

        doSomething1 = (x) =>
        {
            int result = x * x +100;
            return result;
        };
        result = doSomething1(2);
        Debug.Log("���2 = " + result);

        //Test(doSomething1, 2) ���� ���� ���� ���༭
        //�ؿ�ó�� ���� ���� ���� ����
        Test(doSomething1 = (x) =>
        {
            int result = x * x + 100;
            return result;
        }, 2);

        List<int> list = new List<int>();
        for(int i =0; i<10; i++)
        {
            list.Add(i);
        }

        
        //������������
        int? tmp = list.Find(o => o == 99);
        if (tmp.HasValue)
        {
            Debug.Log(tmp);
        }
        else
        {
            Debug.Log("���� �˻��ϴ� �����Ͱ� �������� �ʽ��ϴ�.");
        }

        int? findData = FindData(list, 99);
        if (findData.HasValue)
        {
            Debug.Log(tmp);
        }
        else
        {
            Debug.Log("�Լ� �˻��ϴ� �����Ͱ� �������� �ʽ��ϴ�.");
        }
    }

    //�����ذ�
    //1. Update�Լ����� ���ǹ��� �ѹ��� ����Ͽ� Ư�� �̺�Ʈ���� �Լ� ȣ���� �� �� �ִ�
    //  ���α׷� �ڵ带 �ۼ��Ͻÿ� ��, �Լ� ȣ���� 1���� �Ѵ�
    //2�� �̺�Ʈ �߻��� ȣ���Լ�
    void Update()
    {
        //�����ذ� : �׽�Ʈ
        //���콺 �̺�Ʈ�� �߻����� �� 2�� �̺�Ʈ�� ����
        if (Input.GetMouseButtonDown(0))
        {
            SetEvent(2, EventAction);
        }
        if(ToDo != null)
        {
            ToDo();
            ToDo -= ToDo;
        }
    }
    
    public int? FindData(List<int> _list, int _findData)
    {
        foreach(int one in _list)
        {
            if (one.Equals(_findData))
                return one;
        }
        return null;
    }

    public void Test(Lamda1 _doSomthing, int _arg)
    {
        //�޾ƿ� ���ٽ��� �Ű������� ���⼭ ����������
        int result = _doSomthing(_arg);
        Debug.Log("Test = " + result);
    }


    public void SetEvent(int _eventIndex, Lamda3 _toDo)
    {
        Debug.Log(_eventIndex + "�̺�Ʈ�߻�");
        ToDo = _toDo;
        ToDo += _toDo;
    }

    public void SetEvent(int _eventIndex, Lamda3 [] _todos)
    {
        Debug.Log(_eventIndex + "�̺�Ʈ�߻�");
        foreach(Lamda3 one in _todos)
        {
            ToDo += one;
        }
    }

    public void EventAction()
    {
        Debug.Log("EventAction");
    }
}
