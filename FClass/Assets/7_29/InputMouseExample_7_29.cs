using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouseExample_7_29 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseButton();
    }

    void MouseButton()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("���콺 ���� ��ư ������ ��" + Input.mousePosition);
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("���콺 ������ ��ư ������ ��");
        }

        if (Input.GetMouseButton(2))
        {
            Debug.Log("���콺 �� ��ư ������ ��");
        }
    }

    void OneMouseButton()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("���콺 ���� ��ư" + Input.mousePosition);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("���콺 ������ ��ư");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("���콺 �� ��ư");
        }
    }
}
