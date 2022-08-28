using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//이름이 Do인 델리게이트 선언
delegate void Do();

public class _8_22_Delegate: MonoBehaviour
{
    //2. Do형 변수 deFunction을 선언
    Do deFunction;
    // Start is called before the first frame update
    void Start()
    {
        //3. 델리게이트변수에 사용하고자 하는 함수이름을 대입
        deFunction = Displaydate;
        //4. 델리게이트변수를 호출
        deFunction(); //Displatdata를 호출
    }

    // Update is called once per frame
    void Update()
    {
        if(deFunction != null)
        {
            deFunction();
        }
        /*
        if(1번상황일경우)
            DisplatData1();
        else if(2번상황일경우)
            DisplatData2();
        else if(3번상황일경우)
            DisplatData3();
         */
    }
    void Displaydate()
    {
        Debug.Log("DisplatData");
    }
}
