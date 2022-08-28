using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample_1_8_8 : MonoBehaviour
{
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //aniIndex라는 변수는 integer
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ani.SetInteger("aniIndex", 0);
            Debug.Log("F1");
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            ani.SetInteger("aniIndex", 1);
            Debug.Log("F2");
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            ani.SetInteger("aniIndex", 2);
            Debug.Log("F3");
        }
    }
}
