using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_25_Dictionary : MonoBehaviour
{
    //키를 정수하고 값을 문자열로 하는 Dicionary선언
    Dictionary<int, string> dic;
    //키를 정수로 하고 값을 GameObject로 하는 Dictionary선언
    Dictionary<int, GameObject> dicGameObj;
    //키를 GameObject로 하고 값을 정수로 하는 Dictionary선언
    Dictionary<GameObject, int> dicIntList;

    void Awake()
    {
        dic = new Dictionary<int, string>();
        dicGameObj = new Dictionary<int, GameObject>();
        dicIntList = new Dictionary<GameObject, int>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //dic에 데이터를 추가
        dic.Add(0, "이승엽");
        dic.Add(1, "박찬호");
        dic.Add(2, "이효리");
        //키를 이용하여 값을 사용
        //1.TryGetCalue 함수 사용
        string result;
        if(dic.TryGetValue(0, out result))
        {
            //0에 해당되는 값
            Debug.Log(result);
        }

        if (dic.ContainsKey(2))
        {
            //2라는 키가 존재한다면 키2의 데이터를 출력
            Debug.Log(dic[2]);
        }

        //2.배열처럼사용
        Debug.Log(dic[1]); //키가 1인 데이터 출력
        if(dic[2] != null && dic[2].Equals("이효리"))
        {
            Debug.Log("키가 2인 값은 이효리 입니다.");
        }
        //키와 값을 모두를 출력하려면
        foreach(KeyValuePair<int, string> one in dic)
        {
            Debug.LogFormat("key = {0} value = {1}", one.Key, one.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
