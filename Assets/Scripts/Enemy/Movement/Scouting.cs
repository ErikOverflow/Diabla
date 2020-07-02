using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scouting : MonoBehaviour
{

    Movement movement;

    private void Awake()
    {
        movement = GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if (!player)
        {
            return;
        }
        movement.StartMovement(player.transform);
    }
}
