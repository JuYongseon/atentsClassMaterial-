using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//구조체(struct)
//값타입의 사용자 정의 자료형
public struct Data{
    public int data1;
    public float data2;

    public void Test()
    {

    }
}

//열거체(enum)
//값타입의 사용자 정의 자료형
//단어에 숫자의 값을 적용해서 사용
// 첫번쨰 데이터는 0으로 시작하고 1씩 숫자의 값이 증가
public enum eData
{
    NONE,
    BLACK,
    TWO
}


public class DataType_7_28 : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
