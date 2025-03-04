using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueAnimate : MonoBehaviour
{
    public robotMove a;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(a.isRight)
            animator.Play("blueRight");
        else
            animator.Play("blueLeft");
    }
}
