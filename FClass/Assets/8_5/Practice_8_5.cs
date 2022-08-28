using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_8_5 : MonoBehaviour
{
    //Character������ �ִ� �������� �ε��Ͽ� ����Ʈ�� ����
    //����Ʈ���� ���ϴ� ���ӿ�����Ʈ�� �˻��Ͽ� �ν��Ͻ��� �����ϴ� �Լ��� ����

    List<GameObject> rcChaList;

    void Awake()
    {
        rcChaList = new List<GameObject>();
        TextAsset textAsset = Resources.Load<TextAsset>("StringData");
        Debug.Log(textAsset.text);
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] rcArr = Resources.LoadAll<GameObject>("Character/");
        foreach(GameObject one in rcArr)
        {
            rcChaList.Add(one);
        }
        CreateCharacter("Meshtint Free Knight");
    }

    GameObject FindCharacter(string name)
    {
        foreach(GameObject one in rcChaList)
        {
            if (one.name.Equals(name))
            {
                return one;
            }
        }
        return null;
    }

    GameObject CreateCharacter(string name)
    {
        GameObject rcCha = FindCharacter(name);
        if(rcCha != null)
        {
            GameObject createObj = GameObject.Instantiate<GameObject>(rcCha);
            return createObj;
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
