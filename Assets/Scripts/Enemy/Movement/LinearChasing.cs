using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearChasing : Movement
{
    private new void Awake()
    {
        base.Awake();
        Debug.Log("Scouting");
    }
    Transform target;
    public override void StartMovement(Transform _transform)
    {
        target = _transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!target)
        {
            return;
        }
        rb2d.velocity = (target.position - transform.position).normalized * 0.3f;
    }
}
