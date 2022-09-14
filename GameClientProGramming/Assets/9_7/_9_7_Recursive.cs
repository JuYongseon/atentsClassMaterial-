using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _9_7_Recursive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform findTr = FindGameObjectInChild("Bip001 Neck", transform);
        if(findTr != null)
        {
            Debug.Log(findTr.name);
        }
    }

    public Transform FindGameObjectInChild(string _name, Transform _tr)
    {
        if(_tr.name == _name)
        {
            return _tr;
        }
        for(int i =0; i<_tr.childCount; i++)
        {
            Transform childTr = FindGameObjectInChild(_name, _tr.GetChild(i));
            if(childTr != null)
            {
                return childTr;
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
