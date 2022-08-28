using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck_8_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //충돌시작시 호출되는 콜백함수
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌시작시 충돌한 게임오브젝트 이름 = "+ collision.gameObject.name);
    }
    //충돌진행중 호출되는 콜백함수
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 진행중 호출 = " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 종료시 호출 = " + collision.gameObject.name);
    }

    //Trigger 방식의 충돌
    //충돌시의 물리량을 적용하지 않은 충돌
    //물리량의 충돌을 적용한 출동과 콜백함수가 다르다.
    //cube에 boxCollider 컴포넌트의 is trigger을 체크하면 출력 가능!
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 충돌 시작 = " + other.name);
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("트리거 충돌 중 = " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("트리거 충돌 종료 = " + other.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
