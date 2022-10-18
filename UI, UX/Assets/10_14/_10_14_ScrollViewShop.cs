using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _10_14_ScrollViewShop : MonoBehaviour
{
    public ScrollRect scrolRect;
    public _10_14_Item itemSrc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject newItem = Instantiate<GameObject>(itemSrc.gameObject);
            newItem.SetActive(true);
            newItem.transform.SetParent(scrolRect.content);
        }
    }
}
