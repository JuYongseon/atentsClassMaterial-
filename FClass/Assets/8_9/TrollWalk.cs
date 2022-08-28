using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollWalk : StateMachineBehaviour
{
    AnimationExample_2_8_9 character;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        character = animator.GetComponent<AnimationExample_2_8_9>();
        Debug.Log("TrollWalk OnStateEnter");
    }
    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (character.transform.position == character.END)
        {
            animator.SetInteger("aniIndex",0);
        }
        Move();
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("TrollWalk OnStateExit");
    }
    public void Move()
    {
        character.transform.position = 
            Vector3.MoveTowards(character.transform.position, 
                                character.END, 
                                Time.deltaTime * character.MOVESPEED);
    }
    public void Rotate()
    {

    }



    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
