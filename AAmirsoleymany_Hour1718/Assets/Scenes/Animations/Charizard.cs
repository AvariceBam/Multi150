using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charizard : MonoBehaviour
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
        if (Input.GetKeyDown("s"))
        {
            animator.SetTrigger("Flip");
        }
        if (Input.GetKeyDown("w"))
        {
            animator.SetTrigger("Jump"); 
        }
        if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Color");
        }
        if (Input.GetKeyDown("d"))
        {
            animator.SetTrigger("Scale");
        }
    }
}
