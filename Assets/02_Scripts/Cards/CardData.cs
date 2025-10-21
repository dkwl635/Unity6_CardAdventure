using UnityEngine;



[CreateAssetMenu(fileName = "Card", menuName = "Cards/Card")]
public class CardData : ScriptableObject
{
    public string CardName;
    public Sprite Icon = null;
    public CardType Type = CardType.NONE;
   [TextArea] public string Description;
}
