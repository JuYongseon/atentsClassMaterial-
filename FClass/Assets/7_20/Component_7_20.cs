using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component_7_20 : MonoBehaviour
{
    public GameObject obj_1;
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider tmpCollider = GetComponent<BoxCollider>();

        //MeshRenderer ������Ʈ�� ���������� �����Ͻÿ�.
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        //Component_7_20 tmp = GetComponent<Component_7_20>();
        Component_7_20 tmp = this;

        //���� Sphere�� �����ϰ� Spgere�� SphereCollider�� ���������� �����Ͻÿ�.
        SphereCollider obj1Collider = obj_1.GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        //�̵��� �����ϴ� ���
        // 1. Translate�Լ� �̿�
        transform.Translate(0.01f, 0, 0);
    }
}
