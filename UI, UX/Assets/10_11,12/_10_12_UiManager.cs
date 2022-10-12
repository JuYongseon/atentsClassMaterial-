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
        //ui�� ũ��
        Vector2 size = uiButton.gameObject.GetComponent<RectTransform>().sizeDelta;
        //�Ǵ�
        float width = uiButton.gameObject.GetComponent<RectTransform>().rect.width;
        float height = uiButton.gameObject.GetComponent<RectTransform>().rect.height;
        //��ũ��Ʈ������ ���� �� �� ����
        uiButton.onClick.AddListener(OkButtonClickTypeA);
        //����
        //uiButton.onClick.RemoveListener(OkButtonClickTypeB);
    }

    void Update()
    {
        
    }
    public void OkButtonClickTypeA()
    {
        Debug.Log("A����");
        uiButton.onClick.RemoveListener(OkButtonClickTypeA);
        uiButton.onClick.AddListener(OkButtonClickTypeB);
        uiButtonAni.SetTrigger("ButtonScale");
    }
    public void OkButtonClickTypeB()
    {
        Debug.Log("B����");
        uiButton.onClick.RemoveListener(OkButtonClickTypeB);
        uiButton.onClick.AddListener(OkButtonClickTypeA);
        uiButtonAni.SetTrigger("ButtonNormal");
    }
}
