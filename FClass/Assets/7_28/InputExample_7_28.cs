using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExample_7_28 : MonoBehaviour
{
    public GameObject item;
    Vector3 v1;
    Vector3 v2;
    float moveSpeed;
    float dx;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5,5,0);
        v1 = new Vector3(10, 10, 10);
        moveSpeed = 2f;
        dx = Time.deltaTime * moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        GteItem();
    }

    void GteItem()
    {

        float mx = 0f;
        float my = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mx = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mx = 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            my = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            my = -1f;
        }
        Vector3 tmp = transform.position;
        tmp.x += mx * dx;
        tmp.y += my * dx;
        transform.position = tmp;

        float distance = Vector3.Distance(transform.position, item.transform.position);
        if(distance < 1.0f)
        {
            if(item.activeSelf == true)
            {
                Debug.Log("아이템 획득");
            }
            item.SetActive(false);//게임오브젝트 활성화 비활성화 함수
        }
            
    }

    void KeyTest()
    {
        //스페이스 누르게 되면 출력
        
        if (Input.GetKeyDown("space"))
            Debug.Log("space key was pressed");
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("space key was pressed");
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("space key was pressed");
            transform.position = v1;
        }
    }

    void MoveType1()
    {
        //GetKey함수는 키를 누르고 있는 동안의 의미
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-dx, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(dx, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, dx, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -dx, 0);
        }
    }

    void MoveType2()
    {
        //내가 만든거
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v2.x -= dx;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v2.x += dx;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            v2.y += dx;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v2.y -= dx;
        }
        transform.position = v2;
        */

        //강사님이 만든거
        float mx = 0f;
        float my = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mx = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mx = 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            my = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            my = -1f;
        }
        Vector3 tmp = transform.position;
        tmp.x += mx * dx;
        tmp.y += my * dx;
        transform.position = tmp;
    }

}
