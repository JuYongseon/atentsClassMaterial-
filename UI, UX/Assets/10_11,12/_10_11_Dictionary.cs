using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_11_Dictionary : MonoBehaviour
{
    //Dictionary��?
    //Ű�� ���� �ѽ����� �ϴ� �ڷᱸ��(c#)
    //Ű���� ������ ���� Ư¡(Ű�� �ߺ��� �� ����)
    //Dictionary<Ű�� �ڷ���, ���� �ڷ���>
    Dictionary<int, int> dic1;
    Dictionary<float, int> dic2;
    Dictionary<string, string> dic3;

    //��Ƽ��
    //Ű�� �ش�Ǵ� ���� ������ �� ���
    //Ű�� �����Ѱ��� Ư¡
    //-<������ Ű �ϳ��� �����ϴ� ���� ������ �� ���
    //
    Dictionary<int, List<int>> multiDic1;
    Dictionary<string, List<string>> multiDic2;
    void Start()
    {
        dic1 = new Dictionary<int, int>();
        dic1.Add(0, 100);//��ųʸ��� ����
        dic1.Add(1, 101);
        //Ű�� �ش�Ǵ� ���� ���
        int findValue;
        if(dic1.TryGetValue(0, out findValue))
        {
            //Ű�� �ش�Ǵ� ���� ������ ��� findValue������ ���� ����
            Debug.Log(findValue);
        }
        Debug.Log(dic1[1]);

        dic3 = new Dictionary<string, string>();
        dic3.Add("ȫ", "�浿");
        dic3.Add("������", "123");
        string findString;
        if (dic3.TryGetValue("ȫ", out findString))
        {
            Debug.Log(findString);
        }






        //ref�� �ʱ�ȭ �ؾ���
        //out�� �ʱ�ȭ ���ص� ��
        int data = 100;
        Test(ref data);
    }
    public void Test(ref int a)
    {

    }
    void Update()
    {
        
    }
}
