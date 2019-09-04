using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = -transform.up * speed;
    }
 
}
