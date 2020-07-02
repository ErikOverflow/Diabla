#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    //[SerializeField] Animator animator;
    [SerializeField] CombatStats combatStats;

    private void Update()
    {
        //animator.SetBool("attacking", Input.GetMouseButton(0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Defend defend = collision.GetComponent<Defend>();
        defend?.TakeDamage(combatStats.Attack);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Defend defend = collision.collider.GetComponent<Defend>();
        Debug.Log(defend);
        defend?.TakeDamage(combatStats.Attack);
    }
}
