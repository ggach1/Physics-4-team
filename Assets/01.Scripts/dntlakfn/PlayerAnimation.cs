using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerMove pm;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        pm = GetComponent<PlayerMove>();
    }

    private void Move()
    {
        animator.SetInteger("Move", (int)(Mathf.Abs(pm.moveDir.x) + Mathf.Abs(pm.moveDir.z)));
    }

    private void Jump()
    {
        animator.SetBool("IsGround", pm.isGround);
    }

    private void Update()
    {
        Move();
        Jump();
    }
}
