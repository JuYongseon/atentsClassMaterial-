using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//싱글톤이란
//프로젝트내에서 유일한 인스턴스
//static의 특성을 이용한 클래스
//유니티에서 컴포넌트 타입의 싱글톤과 그렇지 않은 싱글톤을 사용할 수 있다.
//구조를 갖는 곳에는 싱글톤이 좋지 않다.
//프로젝트 내에 유일한 인스턴스가 필요하면 싱글톤을 사용
public class _8_12_SingleTonExample : MonoBehaviour
{
    public static _8_12_SingleTonExample singleTon;

    private void Awake()
    {
        if (singleTon == null)
            singleTon = this;
    }

    public void TestFuction()
    {
        Debug.Log("TestFunction");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
