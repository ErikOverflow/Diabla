#pragma warning disable 0649
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStats : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] int attack;
    [SerializeField] bool alive;
    
    public int Attack { get => attack; }
    public int Health { get => health; }
    public bool Alive { get => alive; }

    public event Action OnHealthChanged;
    public event Action OnAliveChanged;

    public void AddHealth(int amount)
    {
        health += amount;
        OnHealthChanged?.Invoke();
    }

    public void SetAlive(bool _alive)
    {
        alive = _alive;
        OnAliveChanged?.Invoke();
    }
}
