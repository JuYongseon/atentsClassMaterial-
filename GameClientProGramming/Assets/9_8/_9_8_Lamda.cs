using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//반환형식이 int이고 매개변수가 정수인 델리게이트 선언
//public delegate int Do(int _a); Do라고 사용할수 없는 이유는 어디서 Do라고 사용하고 있어서(클래스나 전역변수로)
public delegate int Lamda1(int _a);
public delegate int Lamda2();
public delegate void Lamda3();

public class _9_8_Lamda : MonoBehaviour
{
    int i;

    Lamda1 doSomething1;
    Lamda2 doSomething2;
    Lamda3 doSomething3;
    //문제해결
    Lamda3 ToDo;
    // Start is called before the first frame update
    void Start()
    {
        //람다식을 이용하여 함수를 정의하고 대입
        doSomething1 = (x) => x * x;
        doSomething2 = () => 2 * 2;
        doSomething3 = () => Debug.Log("hi");
        doSomething3 = () => i = 2 * 2;
        //doSomething은 람다식으로 정의한 함수의 구문을 실행
        int result = doSomething1(4);
        Debug.Log("결과1 = " + result);

        doSomething1 = (x) =>
        {
            int result = x * x +100;
            return result;
        };
        result = doSomething1(2);
        Debug.Log("결과2 = " + result);

        //Test(doSomething1, 2) 같음 위에 정의 해줘서
        //밑에처럼 식을 넣을 수도 있음
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

        
        //람다형식으로
        int? tmp = list.Find(o => o == 99);
        if (tmp.HasValue)
        {
            Debug.Log(tmp);
        }
        else
        {
            Debug.Log("람다 검색하는 데이터가 존재하지 않습니다.");
        }

        int? findData = FindData(list, 99);
        if (findData.HasValue)
        {
            Debug.Log(tmp);
        }
        else
        {
            Debug.Log("함수 검색하는 데이터가 존재하지 않습니다.");
        }
    }

    //문제해결
    //1. Update함수에서 조건문을 한번만 사용하여 특정 이벤트에만 함수 호출을 할 수 있는
    //  프로그램 코드를 작성하시오 단, 함수 호출은 1번만 한다
    //2번 이벤트 발생시 호출함수
    void Update()
    {
        //문제해결 : 테스트
        //마우스 이벤트가 발생했을 때 2번 이벤트를 대입
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
        //받아온 람다식의 매개변수는 여기서 선언해줬음
        int result = _doSomthing(_arg);
        Debug.Log("Test = " + result);
    }


    public void SetEvent(int _eventIndex, Lamda3 _toDo)
    {
        Debug.Log(_eventIndex + "이벤트발생");
        ToDo = _toDo;
        ToDo += _toDo;
    }

    public void SetEvent(int _eventIndex, Lamda3 [] _todos)
    {
        Debug.Log(_eventIndex + "이벤트발생");
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
