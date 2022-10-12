using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_12_UiManager : MonoBehaviour
{
    public Button uiButton;
    public Animator uiButtonAni;
    void Start()
    {
        //ui의 크기
        Vector2 size = uiButton.gameObject.GetComponent<RectTransform>().sizeDelta;
        //또는
        float width = uiButton.gameObject.GetComponent<RectTransform>().rect.width;
        float height = uiButton.gameObject.GetComponent<RectTransform>().rect.height;
        //스크립트에서도 설정 할 수 있음
        uiButton.onClick.AddListener(OkButtonClickTypeA);
        //제거
        //uiButton.onClick.RemoveListener(OkButtonClickTypeB);
    }

    void Update()
    {
        
    }
    public void OkButtonClickTypeA()
    {
        Debug.Log("A눌림");
        uiButton.onClick.RemoveListener(OkButtonClickTypeA);
        uiButton.onClick.AddListener(OkButtonClickTypeB);
        uiButtonAni.SetTrigger("ButtonScale");
    }
    public void OkButtonClickTypeB()
    {
        Debug.Log("B눌림");
        uiButton.onClick.RemoveListener(OkButtonClickTypeB);
        uiButton.onClick.AddListener(OkButtonClickTypeA);
        uiButtonAni.SetTrigger("ButtonNormal");
    }
}
