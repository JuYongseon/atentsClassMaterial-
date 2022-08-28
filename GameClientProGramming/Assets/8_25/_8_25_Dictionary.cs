using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_25_Dictionary : MonoBehaviour
{
    //Ű�� �����ϰ� ���� ���ڿ��� �ϴ� Dicionary����
    Dictionary<int, string> dic;
    //Ű�� ������ �ϰ� ���� GameObject�� �ϴ� Dictionary����
    Dictionary<int, GameObject> dicGameObj;
    //Ű�� GameObject�� �ϰ� ���� ������ �ϴ� Dictionary����
    Dictionary<GameObject, int> dicIntList;

    void Awake()
    {
        dic = new Dictionary<int, string>();
        dicGameObj = new Dictionary<int, GameObject>();
        dicIntList = new Dictionary<GameObject, int>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //dic�� �����͸� �߰�
        dic.Add(0, "�̽¿�");
        dic.Add(1, "����ȣ");
        dic.Add(2, "��ȿ��");
        //Ű�� �̿��Ͽ� ���� ���
        //1.TryGetCalue �Լ� ���
        string result;
        if(dic.TryGetValue(0, out result))
        {
            //0�� �ش�Ǵ� ��
            Debug.Log(result);
        }

        if (dic.ContainsKey(2))
        {
            //2��� Ű�� �����Ѵٸ� Ű2�� �����͸� ���
            Debug.Log(dic[2]);
        }

        //2.�迭ó�����
        Debug.Log(dic[1]); //Ű�� 1�� ������ ���
        if(dic[2] != null && dic[2].Equals("��ȿ��"))
        {
            Debug.Log("Ű�� 2�� ���� ��ȿ�� �Դϴ�.");
        }
        //Ű�� ���� ��θ� ����Ϸ���
        foreach(KeyValuePair<int, string> one in dic)
        {
            Debug.LogFormat("key = {0} value = {1}", one.Key, one.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
