using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollIdle : StateMachineBehaviour
{
    AnimationExample_2_8_9 character;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // AnimationExample_2_8_9 스크립트가 추가된 게임오브젝트에 접근하기 위해서는 GetComponent함수사용
        character = animator.GetComponent<AnimationExample_2_8_9>();
        if (character != null)
        {
            Debug.Log(character.END);
        }
        Debug.Log(animator.gameObject.name);
        Debug.Log(animator.transform.position);
        Debug.Log("TrollIdle OnStateEnter");
    }
    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(character.END != animator.transform.position)
        {
            animator.SetInteger("aniIndex", 1);
        }
    }
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("TrollIdle OnStateExit");
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
