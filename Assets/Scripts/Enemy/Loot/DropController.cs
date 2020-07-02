#pragma warning disable 0649
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{
    [SerializeField] DeathController deathController;
    [SerializeField] GameObject lootPrefab;

    private void OnEnable()
    {
        deathController.OnDeath += DropLoot;
    }

    private void OnDisable()
    {
        deathController.OnDeath -= DropLoot;
    }

    private void DropLoot()
    {
        GameObject lootObject = Instantiate(lootPrefab);
        lootPrefab.transform.position = transform.position;
    }
}
