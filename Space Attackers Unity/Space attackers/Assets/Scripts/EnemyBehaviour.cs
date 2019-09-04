using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBehaviour : MonoBehaviour
{
    private float speed = 1f;
    private bool TargetReached = false;
    public Transform Target;
    public Transform Left;
    public Transform Right;
    public bool _Left = false;
    public bool _Right = false;


    public void Update()
    {
        MoveToTarget();
        HorizontalMovement();
    }

    void MoveToTarget()
    {
        if (TargetReached == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, Target.position, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, Target.position) < 0.5f)
            {
                TargetReached = true;
                _Left = true;
            }
        }
    }

    void HorizontalMovement()
    {

        if (_Left == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Left.position, Time.deltaTime * speed);
        }
        if (Vector3.Distance(transform.position, Left.position) < 0.5f)
        {
            _Left = false;
            _Right = true;
        }

        if (_Right == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Right.position, Time.deltaTime * speed);
        }
        if (Vector3.Distance(transform.position, Right.position) < 0.5f)
        {
            _Right = false;
            _Left = true;
        }
    }

}
