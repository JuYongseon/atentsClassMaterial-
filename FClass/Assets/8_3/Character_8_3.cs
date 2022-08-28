using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_8_3 : MonoBehaviour
{
    Vector3 end;
    float rotateSpeed;
    float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        end = transform.position;
        rotateSpeed = 3f;
        moveSpeed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //LookAtExample();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//광선을 발사 할 시작 부분을 설정
            RaycastHit hitInfo;//광선의 목표물에 대한 값을 저장 할 곳

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))//광선의 시작점 저장 할 곳 거리제한 같은 조건
            {
                if (hitInfo.collider.CompareTag("Terrain"))//게임오브젝트의 Terrain태그만 반응하게
                {
                    end = hitInfo.point;
                    Debug.Log(end);
                }
            }
        }
        Vector3 tmp = transform.position;
        tmp.y = end.y;
        Vector3 dir = end - tmp;
        Vector3 newDir =
            Vector3.RotateTowards(transform.forward, dir.normalized, Time.deltaTime * rotateSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);
        Debug.DrawLine(transform.position, end, Color.green);

        //이동
        transform.position = Vector3.MoveTowards(transform.position, end, Time.deltaTime * moveSpeed);
    
     }

    void LookAtExample()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                transform.LookAt(hitInfo.point);
            }
        }
    }
}
