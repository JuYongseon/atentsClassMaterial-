using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_7_26 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1~99������ ���
        int number = Random.Range(1, 100);
        Debug.Log("���� �� + "+number);
        if(10 < number && number < 20)
        {
            Debug.Log("�˻� �Ϸ�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
