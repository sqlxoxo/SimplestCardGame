using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class CardInfoScr : MonoBehaviour
{
    public Card SelfCard;
    public Image Logo;
    public TextMeshProUGUI Name;

    public void HideCardInfo(Card card)
    {
        SelfCard = card;
        Logo.sprite = null;
        Name.text = "";
    }

    public void ShowCardInfo(Card card)
    {
        SelfCard = card;

        Logo.sprite = card.Logo;
        Logo.preserveAspect = true;
        Name.text = card.Name;

    }

    public void Start()
    {
        // ShowCardInfo(CardManager.AllCards[transform.GetSiblingIndex()]);
    }

}
