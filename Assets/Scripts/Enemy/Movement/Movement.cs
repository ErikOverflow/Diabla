using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Debug.Log("Movement");
    }

    public abstract void StartMovement(Transform transform);
}
