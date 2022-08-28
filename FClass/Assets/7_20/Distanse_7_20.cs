using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distanse_7_20 : MonoBehaviour
{
    public GameObject obj_1; //에디터에서 Cube를 대입
    public GameObject obj_2; //에디터에서 Spgere를 대입

    void Start()
    {
        //1. Find함수를 사용해서 게임오브젝트를 검색할 수 있다.
        GameObject obj1 = GameObject.Find("Cube");
        GameObject obj2 = GameObject.Find("Sphere");

        float distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        Debug.Log(distance);

        //2. 에디터상에서 씬에 올려진 게임오브젝트를 대입해서 사용
        distance = Vector3.Distance(obj_1.transform.position, obj_2.transform.position);
        Debug.Log(distance);
    }

    void Update()
    {
        
    }
}
