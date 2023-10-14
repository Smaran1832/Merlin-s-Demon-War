using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card" , menuName = "CardName/Card")]
public class CardData : ScriptableObject
{
   public enum DamageType
    {
        Fire,
        Ice,
        Both
    }
    public string cardTitle;
    public string description;
    public int cost;
    public int damage;
    public DamageType damagetype;
    public Sprite cardImage;
    public Sprite frameImage;
    public int numberInDeck;
    public bool isDefensecard=false;
    public bool isMirrorcard=false;
    public bool isMulti=false;

}
