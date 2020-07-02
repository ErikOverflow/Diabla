#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    [SerializeField] CombatStats combatStats;

    public void TakeDamage(int damage)
    {
        combatStats.AddHealth(-damage);
    }
}
