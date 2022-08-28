using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//원하는 리소스를 검색하여 인스턴스를 생성
//씬에 고유한 기능이 존재할 경우에 대비
public class _8_12_FieldManager : MonoBehaviour
{
    _8_12_Player Player;
    _8_12_Monster monster;
    List<_8_12_Monster> mobList;

    void Awake()
    {
        mobList = new List<_8_12_Monster>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreatePlaterChar(string _name)
    {
        GameObject tmpPlayerChar = _8_12_ResourcesManager.instance.GetCharResource(_name);
        if(tmpPlayerChar != null)
        {
            GameObject playerObject = GameObject.Instantiate<GameObject>(tmpPlayerChar);
            Player = playerObject.AddComponent<_8_12_Player>();
        }
    }
    public void CreateMonster(string _name)
    {
        //매개변수로 전달받은 이름의 몬스터를 생성하고 
        //생선한 몬스터를 리스트에 저장
        GameObject tmpMonster = _8_12_ResourcesManager.instance.GetMonsterResource(_name);
        if(tmpMonster != null)
        {
            GameObject MonsterObject = GameObject.Instantiate<GameObject>(tmpMonster);
            monster = MonsterObject.AddComponent<_8_12_Monster>();
            mobList.Add(monster);
        }
    }
    public void CreateNpc(string _name)
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
