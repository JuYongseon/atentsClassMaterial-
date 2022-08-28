using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _8_18_GameManager : MonoBehaviour
{
    List<_8_18_Monster> mobList;
    public Transform mobParent;

    void Awake()
    {
        mobList = new List<_8_18_Monster>();
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateCharacter(Vector3.zero, "Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public _8_18_Monster CreateCharacter(Vector3 _origin, string _name)
    {
        _origin.y += 100f;
        RaycastHit hit;
        if(Physics.Raycast(_origin, -Vector3.up, out hit, Mathf.Infinity))
        {
            GameObject rcCha = _8_18_ResourceManager.instance.GetCharacter(_name);
            GameObject obj = GameObject.Instantiate<GameObject>(rcCha, hit.point, Quaternion.identity);
            _8_18_Monster script = obj.AddComponent<_8_18_Monster>();
            mobList.Add(script);
            return script;
        }
        return null;
    }
    */

    public _8_18_Monster CreateCharacter(Vector3 _origin, string _name)
    {
        Vector3? terrainPos = GetTerrainPosition(_origin);
        if (terrainPos.HasValue)
        {
            GameObject rcCha = _8_18_ResourceManager.instance.GetCharacter(_name);
            GameObject obj = GameObject.Instantiate<GameObject>(rcCha, terrainPos.Value, Quaternion.identity);
            obj.transform.SetParent(mobParent);
            _8_18_Monster script = obj.AddComponent<_8_18_Monster>();
            mobList.Add(script);
            return script;
        }
        return null;
    }

    public Vector3? GetTerrainPosition(Vector3 _origin)
    {
        _origin.y += 100f;
        RaycastHit hit;
        if (Physics.Raycast(_origin, -Vector3.up, out hit, Mathf.Infinity))
        {
            return hit.point;
        }
        return null;
    }
}
