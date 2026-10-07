using UnityEngine;

public class Playeranimations : MonoBehaviour
{
    private Animator animator;
    private Playercontrol control;

   
    void Awake()
    {
        animator = GetComponent<Animator>();
        control = GetComponent<Playercontrol>();
    }


    void Update()
    {
        animator.SetInteger("pmove", control.MoveValueX());
     
        
       animator.SetInteger("pjump", control.JumpValue());
        animator.SetBool("pground", control.OnGround());
        
        
    }
}
