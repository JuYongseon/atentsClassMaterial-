using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�̱����̶�
//������Ʈ������ ������ �ν��Ͻ�
//static�� Ư���� �̿��� Ŭ����
//����Ƽ���� ������Ʈ Ÿ���� �̱���� �׷��� ���� �̱����� ����� �� �ִ�.
//������ ���� ������ �̱����� ���� �ʴ�.
//������Ʈ ���� ������ �ν��Ͻ��� �ʿ��ϸ� �̱����� ���
public class _8_12_SingleTonExample : MonoBehaviour
{
    public static _8_12_SingleTonExample singleTon;

    private void Awake()
    {
        if (singleTon == null)
            singleTon = this;
    }

    public void TestFuction()
    {
        Debug.Log("TestFunction");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
