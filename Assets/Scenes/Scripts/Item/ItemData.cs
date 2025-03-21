using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("info")]
    public float hp;
    public float attack;
    public float defense;
    public float critical;
    public CharacterColor color;
    public Sprite sprite;
    public bool equiped;
}
