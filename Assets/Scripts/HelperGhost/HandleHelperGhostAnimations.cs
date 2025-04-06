using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHelperGhostAnimations : MonoBehaviour
{
    Animator animator;
    Player player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); ;
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }   

    public void OnAnimationComplete()
    {
        player.currentPlayerState = Player.PlayerState.INGAME;
        Destroy(gameObject);
    }
}
