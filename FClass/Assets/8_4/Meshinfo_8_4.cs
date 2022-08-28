using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshinfo_8_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Cube�� �߰��Ǿ� �ִ� Mesh������ ����
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        for(int i =0; i<meshFilter.mesh.vertexCount; i++)
        {
            //������ǥ�� �ڽ��� �߾����� ���������� ��ǥ
            Debug.Log("���� ��ǥ : " + meshFilter.mesh.vertices[i]);

            //������ ���� ��ǥ�� ���ϱ� ���ؼ��� �ڽ��� ��ġ�� �����ش�
            Vector3 worldPos = transform.position + meshFilter.mesh.vertices[i];
            Debug.Log("�ڽ��� ��ġ�� ���ؼ� ����� ������ǥ : " + worldPos);

            //������ǥ�� ���ϱ� ���� �Լ� ���
            worldPos = transform.TransformPoint(meshFilter.mesh.vertices[i]);
            Debug.Log("�Լ��� ����Ͽ� ����� ������ǥ : " + worldPos);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
