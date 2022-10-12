using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_11_Multimap<Tkey, TValue>
{
    public _10_11_Multimap()
    {
        dic = new Dictionary<Tkey, List<TValue>>();
    }
    public Dictionary<Tkey, List<TValue>> dic;
    public void Add(Tkey _key, TValue _val)
    {
        List<TValue> list;
        //key�� ������ ���� �׷��� ���� ��츦 ����
        if(dic.TryGetValue(_key, out list))
        {
            //Ű�� �����Ѵٸ� ���� ����Ʈ�� Add�Ѵ�
            dic[_key].Add(_val);
        }
        else
        {
            //Ű�� �������� �ʴ´ٸ� ����Ʈ�� �����ϰ� ����Ʈ�� �߰�, �׸��� ����Ʈ�� Dictionary�� Add
            list = new List<TValue>();
            list.Add(_val);
            dic.Add(_key, list);
        }
    }
    public List<TValue> GetData(Tkey _key)
    {
        List<TValue> list;
        if (dic.TryGetValue(_key, out list))
        {
            return list;
        }
        else
        {
            return null;
        }
    }
}
