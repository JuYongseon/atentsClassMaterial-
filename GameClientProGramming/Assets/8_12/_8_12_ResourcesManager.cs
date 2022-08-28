using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//리소스(애샛)를 로드하여 저장
//원하는 리소스를 검색하여 반환
public class _8_12_ResourcesManager : MonoBehaviour
{
    public static _8_12_ResourcesManager instance;
    List<GameObject> rcPlaterCharList;
    List<GameObject> rcMobList;
    List<GameObject> rcNpcList;

    private void Awake()
    {
        if(instance != null)
        {
            instance = this;
        }

        GameObject[] tmpChars = Resources.LoadAll<GameObject>("Character/");
        GameObject[] tmpMonsters = Resources.LoadAll<GameObject>("Monster/");
        GameObject[] tmpNpcs = Resources.LoadAll<GameObject>("Npc/");
        
        //리소스 로드 방법1
        foreach(GameObject one in tmpChars)
        {
            rcPlaterCharList.Add(one);
        }
        foreach (GameObject one in tmpMonsters)
        {
            rcMobList.Add(one);
        }
        foreach (GameObject one in tmpNpcs)
        {
            rcNpcList.Add(one);
        }
        //리소스 로드 방법2
        //밑에 하나의 함수로도 리소스를 로드할 수 있다
        //AddList(rcPlaterCharList, tmpChars);
        //AddList(rcMobList, tmpMonsters);
        //AddList(rcNpcList, tmpNpcs);
    }

    void AddList(List<GameObject> _loadList, GameObject[] _reAssets)
    {
        foreach (GameObject one in _reAssets)
        {
            _loadList.Add(one);
        }
    }

    public GameObject GetCharResource(string _name)
    {
        foreach (GameObject one in rcPlaterCharList)
        {
            if (one.name.Equals(_name))
            {
                return one;
            }
        }
        return null;
        //람다코드 방식
        //return rcPlaterCharList.Find(o => (o.name.Equals(_name)));
    }
    public GameObject GetMonsterResource(string _name)
    {
        foreach (GameObject one in rcMobList)
        {
            if (one.name.Equals(_name))
            {
                return one;
            }
        }
        return null;
    }
    public GameObject GetNpcResource(string _name)
    {
        foreach (GameObject one in rcNpcList)
        {
            if (one.name.Equals(_name))
            {
                return one;
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
