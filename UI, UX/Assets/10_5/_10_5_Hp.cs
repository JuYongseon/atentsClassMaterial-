using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_5_Hp : MonoBehaviour
{
    public Image hpImg;
    public Transform HpPosition;
    Vector3 screenPos;
    void Start()
    {
        screenPos = Camera.main.WorldToScreenPoint(HpPosition.position); 
    }

    // Update is called once per frame
    void Update()
    {
        screenPos = Camera.main.WorldToScreenPoint(HpPosition.position);
        hpImg.transform.position = screenPos;
        //hpImg.fillAmount -= Time.deltaTime;
    }
}
