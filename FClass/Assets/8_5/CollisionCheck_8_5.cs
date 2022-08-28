using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck_8_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //�浹���۽� ȣ��Ǵ� �ݹ��Լ�
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹���۽� �浹�� ���ӿ�����Ʈ �̸� = "+ collision.gameObject.name);
    }
    //�浹������ ȣ��Ǵ� �ݹ��Լ�
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ������ ȣ�� = " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ����� ȣ�� = " + collision.gameObject.name);
    }

    //Trigger ����� �浹
    //�浹���� �������� �������� ���� �浹
    //�������� �浹�� ������ �⵿�� �ݹ��Լ��� �ٸ���.
    //cube�� boxCollider ������Ʈ�� is trigger�� üũ�ϸ� ��� ����!
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� �浹 ���� = " + other.name);
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Ʈ���� �浹 �� = " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Ʈ���� �浹 ���� = " + other.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}