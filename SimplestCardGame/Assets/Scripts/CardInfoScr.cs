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
    public TextMeshProUGUI Name, Attack, Health, Defense;
    public GameObject HideObj;

    public void HideCardInfo(Card card)
    {
        SelfCard = card;
        HideObj.SetActive(true);

    }

    public void ShowCardInfo(Card card)
    {
        HideObj.SetActive(false);
        SelfCard = card;

        Logo.sprite = card.Logo;
        Logo.preserveAspect = true;
        Name.text = card.Name;

        Attack.text = SelfCard.Attack.ToString();
        Health.text = SelfCard.Attack.ToString();
        Defense.text = SelfCard.Attack.ToString();

    }

    public void Start()
    {
        // ShowCardInfo(CardManager.AllCards[transform.GetSiblingIndex()]);
    }

}
