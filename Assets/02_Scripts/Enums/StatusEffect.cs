using UnityEngine;

[System.Flags]
public enum StatusEffect
{
    None = 0,
    Poison = 1 << 0,
    //Burn = 1 << 1,
    //Stun = 1 << 2,
    //Freeze = 1 << 3, 
}
