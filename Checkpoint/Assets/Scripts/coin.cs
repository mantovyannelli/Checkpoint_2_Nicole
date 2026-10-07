using UnityEngine;

public class coin : MonoBehaviour
{

    private Animator animator;
    private Playercontrol control;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        animator = GetComponent<Animator>();
        control = GetComponent<Playercontrol>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (animator != null)
        {
            animator.SetTrigger("pcol");
        }

    }
}
