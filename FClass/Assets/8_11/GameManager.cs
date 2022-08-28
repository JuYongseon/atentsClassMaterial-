using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//스크립트인데 GameManager라고 이름을 만들면 아이콘이 톱니바퀴처럼 바뀜
public class GameManager : MonoBehaviour
{
    GameObject rcCha;
    GameObject character;
    Character chaScript;
    // Start is called before the first frame update
    void Awake()
    {
        //리소스를 통해 게임오브젝트를 불러온다
        //리소스 폴더 안의 트롤 자이언트 불러옴
        rcCha = Resources.Load<GameObject>("Character/TrollGiant");
        character = GameObject.Instantiate<GameObject>(rcCha);
        //생성한 게임오브젝트에 스크립트를 프로그램 코드상에서 추가
        chaScript = character.AddComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
