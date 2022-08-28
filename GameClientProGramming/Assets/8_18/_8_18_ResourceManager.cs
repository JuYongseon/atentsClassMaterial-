using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_18_ResourceManager : MonoBehaviour
{
    public static _8_18_ResourceManager instance;
    List<GameObject> rcChaList;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        CharacterLoad();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CharacterLoad()
    {
        if(rcChaList == null)
        {
            rcChaList = new List<GameObject>();
        }

        GameObject[] rcChar = Resources.LoadAll<GameObject>("Character/");
        foreach(GameObject one in rcChar)
        {
            rcChaList.Add(one);
        }
    }
    public GameObject GetCharacter(string _name)
    {
        foreach(GameObject one in rcChaList)
        {
            if (one.name.Equals(_name))
            {
                return one;
            }
        }
        return null;
    }
}
