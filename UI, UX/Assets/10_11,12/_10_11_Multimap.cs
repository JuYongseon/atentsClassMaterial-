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
        //key가 존재할 경우와 그렇지 않은 경우를 구분
        if(dic.TryGetValue(_key, out list))
        {
            //키가 존재한다면 값이 리스트에 Add한다
            dic[_key].Add(_val);
        }
        else
        {
            //키가 존재하지 않는다면 리스트를 생성하고 리스트에 추가, 그리고 리스트를 Dictionary에 Add
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
