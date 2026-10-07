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

    // Update is called once per frame
    void Update()
    {
        

    }
}
