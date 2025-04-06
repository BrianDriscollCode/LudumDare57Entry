using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePlayerAnimations : MonoBehaviour
{
    Animator animator;
    Player player;

    enum playerAnimState
    {
        LEFT,
        RIGHT,
        NON
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        if (player.currentPlayerState == Player.PlayerState.INDIALOG)
        {
            animator.Play("IdleAnim");
            return;
        }

        bool isMovingLeft = Input.GetKey(KeyCode.A);
        bool isMovingRight = Input.GetKey(KeyCode.D);

        if (isMovingLeft)
        {
            animator.Play("RunAnim");
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (isMovingRight)
        {
            animator.Play("RunAnim");
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            animator.Play("IdleAnim");
        }
    }
}
