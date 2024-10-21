using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    // _animator ¼¼ÆÃ 
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        animator.SetInteger("State", animationVariable);
    }
}
