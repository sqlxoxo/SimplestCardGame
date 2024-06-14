using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AtackedCard : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        CardInfoScr card = eventData.pointerDrag.GetComponent<CardInfoScr>();

        if (card && card.SelfCard.CanAttack && transform.parent == GetComponent<CardMovementScr>().GameManager.EnemyField)
        {
            card.SelfCard.ChangeAttackState(false);
            GetComponent<CardMovementScr>().GameManager.CardsFight(card, GetComponent<CardInfoScr>());
        }
    }
}
