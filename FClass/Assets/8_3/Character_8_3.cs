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
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//������ �߻� �� ���� �κ��� ����
            RaycastHit hitInfo;//������ ��ǥ���� ���� ���� ���� �� ��

            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))//������ ������ ���� �� �� �Ÿ����� ���� ����
            {
                if (hitInfo.collider.CompareTag("Terrain"))//���ӿ�����Ʈ�� Terrain�±׸� �����ϰ�
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

        //�̵�
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
