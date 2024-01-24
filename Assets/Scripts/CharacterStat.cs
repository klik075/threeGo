using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    PlayerCat,
    PlayerDog,
    Enemy1,
    Enemy2
}

[Serializable]
public class CharacterStat
{
    public CharacterType type;
    public string characterName;
    public string characterInfo;
    public int lv;
    public float exp;
    public float fullExp;
    public float hp;
    //public AttackSO;

}
