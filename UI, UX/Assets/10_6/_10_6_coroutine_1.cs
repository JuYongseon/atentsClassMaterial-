using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_6_coroutine_1 : MonoBehaviour
{
    IEnumerator coroutine;
    private void Awake()
    {
        coroutine = Test_1();
    }
    // Start is called before the first frame update
    IEnumerator Start()
    {
        StartCoroutine(coroutine);
        //다음 업데이트 후에 실행됨 처음은 이전업데이트가 없어서 두번이 됨
        yield return null;
        Debug.Log("111");
        yield return new WaitForSeconds(0.1f);
        yield return StartCoroutine(Test_1());
        yield return StartCoroutine(Test_2());
    }

    IEnumerator Test_1()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + "_@");
            //이전 업데이트가 있기 때문에 다음업데이트이기 때문에 한번만 출력됨
            yield return null;
        }
    }
    IEnumerator Test_2()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + "_#@");
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("***************************");
        if (Input.GetMouseButtonDown(1))
        {
            StopCoroutine(coroutine);
        }
    }
}
