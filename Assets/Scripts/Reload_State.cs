﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload_State : StateMachineBehaviour
{
    // 애니메이션 진행상황이 70% 일 경우에 PlayerController에 접근해서 Reload 메소드를 실행하는 애니메이션 스크립트

    public float reloadTime = 0.7f;
    private bool reloaded = false;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (reloaded)
            return;
        if (stateInfo.normalizedTime >= reloadTime)
        {
            animator.GetComponent<PlayerController>().Reload();
            reloaded = true;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        reloaded = false;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //
}