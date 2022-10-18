using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_14_ScrollViewExam : MonoBehaviour
{
    // 스크롤 뷰의 역할을 하는 컴포넌트
    public ScrollRect scrollRect;
    void Start()
    {
        scrollRect.normalizedPosition = new Vector2(1, 1);
        Debug.Log(scrollRect.content.sizeDelta);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 tmp = scrollRect.normalizedPosition;
        //tmp.x += Time.deltaTime * 0.1f;
        //scrollRect.normalizedPosition = tmp;
    }
}
