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
        //마우스 픽 프로그램 코드 작성
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

        //오프셋 적용
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //스페이스바 키를 눌렀을 경우
            //진행방향의 뒤를 의미하는 프로그램 코드
            //-현재위치에서 목적지로 향하는 벡터를 구한다.
            //-(navAgent.destination - transform.position).normalized
            //시선방향의 뒤를 의미하는 프로그램 코드
            //-transform.forward 내가 바라보는 시선
            navAgent.Move(-transform.forward * 3f);
        }
    }
}
