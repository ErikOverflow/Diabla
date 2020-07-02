using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : Movement
{
    private new void Awake()
    {
        base.Awake();
        Debug.Log("Dash");
    }

    public override void StartMovement(Transform _transform)
    {
        Vector3 target = _transform.position;
        rb2d.velocity = (target - transform.position).normalized * 1.5f;
    }
}
