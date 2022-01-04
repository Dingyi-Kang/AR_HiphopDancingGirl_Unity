using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isTaunt = animator.GetBool("isTaunt");

        bool isDancing = animator.GetBool("isDiving");

        //idle
        if (!isDancing && !isTaunt && Input.GetKey("w")) {

            animator.SetBool("isTaunt", true);
        }
        //release w
        if (isTaunt && !Input.GetKey("w"))
        {
            animator.SetBool("isTaunt", false);
        }

        //idle to dance
        if (!isDancing && !isTaunt && Input.GetKey("1"))
        {

            animator.SetBool("isDiving", true);
        }

        //
        if (isDancing && Input.GetKey("2"))
        {
            animator.SetBool("isDiving", false);
            animator.SetBool("d1", true);
        }

        //
        if (animator.GetBool("d1") && Input.GetKey("3"))
        {
            animator.SetBool("d1", false);
            animator.SetBool("d2", true);
        }

        //
        if (animator.GetBool("d2") && Input.GetKey("4"))
        {
            animator.SetBool("d2", false);
            animator.SetBool("d3", true);
        }

        //
        if (animator.GetBool("d3") && Input.GetKey("5"))
        {
            animator.SetBool("d3", false);
            animator.SetBool("d4", true);
        }

        if (animator.GetBool("d4") && Input.GetKey("6"))
        {
            animator.SetBool("d4", false);
            animator.SetBool("d5", true);
        }

        if (animator.GetBool("d5") && Input.GetKey("7"))
        {
            animator.SetBool("d5", false);
            animator.SetBool("d6", true);
        }

        if (animator.GetBool("d6") && !Input.GetKey("7"))
        {
            animator.SetBool("d6", false);
        }
    }
}
