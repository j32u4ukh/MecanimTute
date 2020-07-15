using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo info;
    static int idle_state = Animator.StringToHash("Base Layer.Idle");
    static int run_state = Animator.StringToHash("Base Layer.Run");
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("is_run", false);

        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("is_run", true);
        }
    }
}
