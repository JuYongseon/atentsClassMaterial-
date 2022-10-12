using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _10_6_coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("4");
        StartCoroutine(DisplayData());
    }
    IEnumerator DisplayData()
    {
        Debug.Log("3");
        //다음 update에 다시 호출을 한다.
        yield return null;
        Debug.Log("11");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("#");
    }
}
