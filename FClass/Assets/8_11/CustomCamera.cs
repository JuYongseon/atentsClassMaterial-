using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCamera : MonoBehaviour
{
    Character player;
    //ĳ���Ͱ� �̵��� ��Ÿ��ŭ �̵������ָ� �ȴ�.
    // Start is called before the first frame update
    void Awake()
    {
        player = gameObject.AddComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
