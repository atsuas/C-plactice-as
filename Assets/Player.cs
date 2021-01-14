using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
        float x = Input.GetAxis("Horizontal");
        if (x > 0)
        {
            animator.SetFloat("speed", x);
        }
        else if (x == 0)
        {
            animator.SetFloat("speed", x);
        }
    }
}
