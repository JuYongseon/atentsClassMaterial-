using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ũ��Ʈ�ε� GameManager��� �̸��� ����� �������� ��Ϲ���ó�� �ٲ�
public class GameManager : MonoBehaviour
{
    GameObject rcCha;
    GameObject character;
    Character chaScript;
    // Start is called before the first frame update
    void Awake()
    {
        //���ҽ��� ���� ���ӿ�����Ʈ�� �ҷ��´�
        //���ҽ� ���� ���� Ʈ�� ���̾�Ʈ �ҷ���
        rcCha = Resources.Load<GameObject>("Character/TrollGiant");
        character = GameObject.Instantiate<GameObject>(rcCha);
        //������ ���ӿ�����Ʈ�� ��ũ��Ʈ�� ���α׷� �ڵ�󿡼� �߰�
        chaScript = character.AddComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
