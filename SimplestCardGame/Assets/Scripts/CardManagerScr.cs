using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public struct Card
{

    public string Name;
    public Sprite Logo;

    public int Attack, Health, Defense;

    public bool CanAttack;

    public bool IsAlive
    {
        get
        {
            return Health > 0;
        }
    }

    public Card(string name, string logoPath, int attack, int health, int defense)
    {
        Name = name;
        Logo = Resources.Load<Sprite>(logoPath);
        Attack = attack;
        Health = health;
        Defense = defense;
        CanAttack = false;


    }

    public void ChangeAttackState(bool can)
    {
        CanAttack = can;
    }

    public void GetDamage(int dmg)
    {
        Health -= dmg;
    }

}

public static class CardManager
{
    public static List<Card> AllCards = new();
}

public class CardManagerScr : MonoBehaviour
{

    public void Awake()
    {
        CardManager.AllCards.Add(new Card("card_1", "Sprites/Cards/Card_1", 5, 5, 0));
        CardManager.AllCards.Add(new Card("card_2", "Sprites/Cards/Card_2", 1, 4, 0));
        CardManager.AllCards.Add(new Card("card_3", "Sprites/Cards/Card_3", 2, 1, 0));
        CardManager.AllCards.Add(new Card("card_4", "Sprites/Cards/Card_4", 3, 3, 0));
        CardManager.AllCards.Add(new Card("card_5", "Sprites/Cards/Card_5", 3, 3, 0));
        CardManager.AllCards.Add(new Card("card_6", "Sprites/Cards/Card_6", 3, 3, 0));
    }

}
