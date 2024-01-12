using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRun : MonoBehaviour
{
    public float speed = 4f;
    public float attackRange = 3f;

    private Transform player;
    private Rigidbody2D rb;
    private Boss boss;
    private Animator animator;

    // Obtener el Animator en Start
    private void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        boss = GetComponent<Boss>();
    }

    // Public function to perform the logic
    public void BossRunUpdate()
    {
        boss.LookAtPlayer();

        Vector2 target = new Vector2(player.position.x, rb.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);

        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
    }
}