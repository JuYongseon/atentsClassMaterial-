using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�̸��� Do�� ��������Ʈ ����
delegate void Do();

public class _8_22_Delegate: MonoBehaviour
{
    //2. Do�� ���� deFunction�� ����
    Do deFunction;
    // Start is called before the first frame update
    void Start()
    {
        //3. ��������Ʈ������ ����ϰ��� �ϴ� �Լ��̸��� ����
        deFunction = Displaydate;
        //4. ��������Ʈ������ ȣ��
        deFunction(); //Displatdata�� ȣ��
    }

    // Update is called once per frame
    void Update()
    {
        if(deFunction != null)
        {
            deFunction();
        }
        /*
        if(1����Ȳ�ϰ��)
            DisplatData1();
        else if(2����Ȳ�ϰ��)
            DisplatData2();
        else if(3����Ȳ�ϰ��)
            DisplatData3();
         */
    }
    void Displaydate()
    {
        Debug.Log("DisplatData");
    }
}
