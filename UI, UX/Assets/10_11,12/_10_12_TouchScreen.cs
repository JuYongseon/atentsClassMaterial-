using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _10_12_TouchScreen : MonoBehaviour, IPointerDownHandler
{
    public Text uiText;
    public float elapsed;
    private Color sourceColor;
    private Color destColor;
    private float tmpElapsed;
    void Start()
    {
        sourceColor = uiText.color;
        destColor = uiText.color;
        destColor.a = 0f;
        tmpElapsed = elapsed;
        Invoke("OffColor", 0.4f);
    }
    void OnColor()
    {
        uiText.color = sourceColor;
        if (IsInvoking("OnColor"))
        {
            CancelInvoke("OnColor");
        }
        Invoke("OffColor", 0.4f);
    }
    void OffColor()
    {
        uiText.color = destColor;
        if (IsInvoking("OffColor"))
        {
            CancelInvoke("OffColor");
        }
        Invoke("OnColor", 0.4f);
    }
    public void OnPointerDown(PointerEventData _eventData)
    {
        Debug.Log("PointerDown À§Ä¡" + _eventData.position);
    }

    // Update is called once per frame
    void Update()
    {
        //tmpElapsed -= Time.deltaTime;
        //if (tmpElapsed <= 0)
        //{
        //    uiText.color = sourceColor;
        //    tmpElapsed = elapsed;
        //}
        //else
        //{
        //    uiText.color = destColor;
        //}
    }
}
