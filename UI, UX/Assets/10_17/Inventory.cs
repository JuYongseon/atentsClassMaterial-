using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler, IPointerUpHandler
{
    public List<Slot> slotList;
    public Image selectedIcon;
    private int selectedSlot;
    private void Awake()
    {
        selectedSlot = -1;
        selectedIcon.gameObject.SetActive(false);
    }
    void Start()
    {
    }
    public void OnPointerDown(PointerEventData _eventData)
    {
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].IsInRect(_eventData.position))
            {
                if(slotList[i].uiIcon.sprite == null)
                {
                    return;
                }
                selectedSlot = i;
                selectedIcon.sprite = Resources.Load<Sprite>("Icon/" + slotList[i].uiIcon.sprite.name);
                selectedIcon.rectTransform.position = _eventData.position;
                selectedIcon.gameObject.SetActive(true);
            }
        }
    }
    public void OnDrag(PointerEventData _eventData)
    {
        if (selectedSlot != -1)
            selectedIcon.rectTransform.position = _eventData.position;
    }

    public void OnEndDrag(PointerEventData _eventData)
    {
        if (selectedSlot == -1)
            return;
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].IsInRect(_eventData.position))
            {
                if (selectedSlot == i)
                {
                    selectedIcon.sprite = null;
                    selectedIcon.gameObject.SetActive(false);
                    selectedSlot = -1;
                    return;
                }

                if (slotList[i].uiIcon.sprite == null)
                {
                    slotList[i].uiIcon.gameObject.SetActive(true);
                    slotList[i].uiIcon.sprite = Resources.Load<Sprite>("Icon/" + slotList[selectedSlot].uiIcon.sprite.name);
                    slotList[i].itemCount.text = slotList[selectedSlot].itemCount.text;

                    slotList[selectedSlot].uiIcon.sprite = null;
                    slotList[selectedSlot].itemCount.text = null;
                    slotList[selectedSlot].uiIcon.gameObject.SetActive(false);
                }
                else
                {
                    if (slotList[i].uiIcon.sprite.name == slotList[selectedSlot].uiIcon.sprite.name)
                    {
                        slotList[i].itemCount.text = (int.Parse(slotList[i].itemCount.text) + int.Parse(slotList[selectedSlot].itemCount.text)).ToString();

                        slotList[selectedSlot].uiIcon.sprite = null;
                        slotList[selectedSlot].itemCount.text = null;
                        slotList[selectedSlot].uiIcon.gameObject.SetActive(false);
                    }
                    else
                    {
                        string tmpName = "Icon/" + slotList[i].uiIcon.sprite.name;
                        slotList[i].uiIcon.sprite = Resources.Load<Sprite>("Icon/" + slotList[selectedSlot].uiIcon.sprite.name);
                        slotList[selectedSlot].uiIcon.sprite = Resources.Load<Sprite>(tmpName);
                        string tmpCount = slotList[i].itemCount.text;
                        slotList[i].itemCount.text = slotList[selectedSlot].itemCount.text;
                        slotList[selectedSlot].itemCount.text = tmpCount;
                    }
                }
                selectedIcon.sprite = null;
                selectedIcon.gameObject.SetActive(false);
                selectedSlot = -1;
                return;
            }
        }
        selectedIcon.sprite = null;
        selectedIcon.gameObject.SetActive(false);
        selectedSlot = -1;
    }

    public void OnPointerUp(PointerEventData _eventData)
    {
        if (selectedSlot == -1)
            return;
        int tmpSelectedSlot = -1;
        for (int i = 0; i < slotList.Count; i++)
        {
            if (slotList[i].IsInRect(_eventData.position))
            {
                tmpSelectedSlot = i;
                break;
            }
        }
        if (tmpSelectedSlot != -1 && tmpSelectedSlot == selectedSlot)
        {
            selectedIcon.sprite = null;
            selectedIcon.gameObject.SetActive(false);
            selectedSlot = -1;
        }
    }
}
