using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityAnimator : MonoBehaviour
{
    public Rigidbody body;
    public Animator animator;

    private void Update()
    {
        animator.SetFloat("Velocity", body.velocity.magnitude);
    }
}
