#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootStats : MonoBehaviour
{
    [SerializeField] string itemName;
    [SerializeField] int level;
    [SerializeField] int attack;

    public string ItemName { get => itemName; }
    public int Level { get => level; }
    public int Attack { get => attack; }
}
