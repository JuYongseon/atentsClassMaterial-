using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCamera : MonoBehaviour
{
    Character player;
    //캐릭터가 이동한 델타만큼 이동시켜주면 된다.
    // Start is called before the first frame update
    void Awake()
    {
        player = gameObject.AddComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
