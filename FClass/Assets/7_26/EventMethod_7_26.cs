using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMethod_7_26 : MonoBehaviour
{
    float fixedTime;
    float updateTime;
    float example2Time;
    int fixedCount;
    int updateCount;
    float dTime;
    // Start is called before the first frame update
    void Awake()
    {
        //Debug.Log("Awake");
    }

    void OnEnable()
    {
        //Debug.Log("OnEnable");
    }

    void OnDisable()
    {
        //Debug.Log("OnDisable");
    }

    void Start()
    {
        //Debug.Log("Start");
    }

    void FixedUpdate()
    {
        /*fixedTime += Time.fixedDeltaTime;
        fixedCount++;
        if (fixedTime >= 1f)
        {
            Debug.Log("FixedUpdate Count = "+fixedCount);
            fixedTime = 0f;
            fixedCount = 0;

        }
        Debug.Log("FixedUpdate");*/
    }

    // Update is called once per frame
    void Update()
    {
       /* updateTime += Time.deltaTime;
        updateCount++;
        if (updateTime >= 1f)
        {
            Debug.Log("Update Count = " + updateCount);
            updateTime = updateTime-1f;
            updateCount = 0;

        }

        example2Time += Time.deltaTime;
        Debug.Log("������ deltaTime = " + example2Time);
        if (example2Time >= 2f)
        {
            Debug.Log("2�� ��� ��");
            example2Time = 0;
        }*/

        dTime += Time.deltaTime;
        if (dTime >= 2f)
        {
            int rTime = (int)dTime % 2;
            if (rTime == 0)
                Debug.Log("¦�� �̺�Ʈ �߻�");
            else
                Debug.Log("Ȧ�� �̺�Ʈ �߻�");
        }
        else
        {
            if (1f <= dTime || dTime <=2f)
            {
                Debug.Log("Ȧ�� �̺�Ʈ �߻�");
            }
        }
    }
    
    void LateUpdate()
    {
        //Debug.Log("LateUpdate");
    }
}
