using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlaceScr : MonoBehaviour, IDropHandler, IPointedEnterHandler, IPointedExitHandler
{
    public void OnDrop(PointerEventData eventData) 
    {
        CardScr card = eventData.pointerDrag.GetComponent<CardScr>();

        if (card)
            card.DefaultParent = transform;
    }

public void OnPointerEnter(PointerEventData eventData)
{
    if (eventData.pointerDrag == null)
    return;

    CardScr card = eventData.pointerDrag.GetComponent<CardScr>();

    if (card)
    card.DefaultTempCardParent = transform;
}

public void OnPointerExit(PointerEventData eventData)
{
if (eventData.pointerDrag == null)
return;

CardScr card - eventData.pointerDrag.GetComponent<CardScr>();

if (card && card.DefaultTempCardParent == transform)
card.DefaultTempCardParent == card.DefaultParent;
}
}
