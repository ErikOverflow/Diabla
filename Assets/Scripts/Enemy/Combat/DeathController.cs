#pragma warning disable 0649
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    [SerializeField] CombatStats combatStats;
    public event Action OnDeath;
    // Start is called before the first frame update
    void OnEnable()
    {
        combatStats.OnHealthChanged += CheckForDeath;
    }

    private void OnDisable()
    {
        combatStats.OnHealthChanged -= CheckForDeath;
    }

    private void CheckForDeath()
    {
        if(combatStats.Health <= 0)
        {
            OnDeath?.Invoke();
        }
    }
}
