using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_11_Dictionary : MonoBehaviour
{
    //Dictionary란?
    //키와 값을 한쌍으로 하는 자료구조(c#)
    //키값은 유일한 것이 특징(키는 중복될 수 없음)
    //Dictionary<키의 자료형, 값의 자료형>
    Dictionary<int, int> dic1;
    Dictionary<float, int> dic2;
    Dictionary<string, string> dic3;

    //멀티맵
    //키에 해당되는 값이 여러개 일 경우
    //키는 유일한것이 특징
    //-<유일한 키 하나에 대응하는 값이 여러개 일 경우
    //
    Dictionary<int, List<int>> multiDic1;
    Dictionary<string, List<string>> multiDic2;
    void Start()
    {
        dic1 = new Dictionary<int, int>();
        dic1.Add(0, 100);//딕셔너리에 저장
        dic1.Add(1, 101);
        //키의 해당되는 값을 사용
        int findValue;
        if(dic1.TryGetValue(0, out findValue))
        {
            //키에 해당되는 값이 존재할 경우 findValue변수에 값이 저장
            Debug.Log(findValue);
        }
        Debug.Log(dic1[1]);

        dic3 = new Dictionary<string, string>();
        dic3.Add("홍", "길동");
        dic3.Add("가나다", "123");
        string findString;
        if (dic3.TryGetValue("홍", out findString))
        {
            Debug.Log(findString);
        }






        //ref는 초기화 해야함
        //out는 초기화 안해도 됨
        int data = 100;
        Test(ref data);
    }
    public void Test(ref int a)
    {

    }
    void Update()
    {
        
    }
}
