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

        //MeshRenderer 컴포넌트를 지역변수에 저장하시오.
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        //Component_7_20 tmp = GetComponent<Component_7_20>();
        Component_7_20 tmp = this;

        //씬에 Sphere를 생성하고 Spgere의 SphereCollider를 지역변수에 대입하시오.
        SphereCollider obj1Collider = obj_1.GetComponent<SphereCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        //이동을 적용하는 방법
        // 1. Translate함수 이용
        transform.Translate(0.01f, 0, 0);
    }
}
