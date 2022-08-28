using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class _8_26_NavMeshCharacter : MonoBehaviour
{
    NavMeshAgent navAgent;
    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 �� ���α׷� �ڵ� �ۼ�
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                if(hitInfo.collider.CompareTag("Terrain"))
                {
                    navAgent.destination = hitInfo.point;
                }
            }
        }

        //������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�����̽��� Ű�� ������ ���
            //��������� �ڸ� �ǹ��ϴ� ���α׷� �ڵ�
            //-������ġ���� �������� ���ϴ� ���͸� ���Ѵ�.
            //-(navAgent.destination - transform.position).normalized
            //�ü������� �ڸ� �ǹ��ϴ� ���α׷� �ڵ�
            //-transform.forward ���� �ٶ󺸴� �ü�
            navAgent.Move(-transform.forward * 3f);
        }
    }
}
