using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ResourceManager에 저장된 프리팹의 인스턴스를 검색하여 원하는 인스턴스를 생성
 */
public class _8_16_GameManager : MonoBehaviour
{
    _8_16_Player player;
    private void Awake()
    {
    }
    void Start()
    {
        CreateCharacterInstance("Cube");
    }
    public void CreateCharacterInstance(string _name)
    {
        GameObject tmp = _8_16_ResourceManager.instance.GetCharResource(_name);
        if (tmp != null)
        {
            GameObject playerObject = GameObject.Instantiate<GameObject>(tmp);
            player = playerObject.AddComponent<_8_16_Player>();
            //_8_16_CustomCamera cam = Camera.main.GetComponent<_8_16_CustomCamera>();
            _8_16_CustomCamera.instance.PLAYER = player;
            _8_16_CustomCamera.instance.PLAYEPOS = player.transform.position;
        }
    }
    void Update()
    {

    }
}
