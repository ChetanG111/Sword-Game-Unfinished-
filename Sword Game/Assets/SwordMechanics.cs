using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMechanics : MonoBehaviour
{
   
    public int damage,moveDamage;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int durability = 1000;
    public Animator animator;
    public LayerMask enemyLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Does a normal swing
        if (Input.GetMouseButtonDown(0))
        {
            NormalSwing();
        }

        
        //does with more force
        if (Input.GetMouseButtonDown(0) && !GetComponent<PlayerMove>().isGrounded)
        {
            ForceSwing();
        }

        //Stabs the enemy
        if(Input.GetKey(KeyCode.LeftShift)&& Input.GetMouseButtonDown(0))
        {
            Stab();
        }

        if(durability <= 0)
        {
            Debug.Log("Your Sword Broke");
        }
    }

    void NormalSwing()
    {
        animator.SetTrigger("Attack");
               Collider[] colliders = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider enemies in colliders)
        {
            enemies.GetComponent<EnemyHealth>().TakeDamage(damage);
            durability -= 10;
        }
    }

    void ForceSwing()
    {
        Collider[] colliders = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider enemies in colliders)
        {
            enemies.GetComponent<EnemyHealth>().TakeDamage(moveDamage);
            durability -= 30;
        }
    }

    void Stab()
    {
       
        Collider[] colliders = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider enemies in colliders)
        {
            enemies.GetComponent<EnemyHealth>().TakeDamage(enemies.GetComponent<EnemyHealth>().maxHealth);
            durability -= 50;
        }
    }

    void UseSwordMagic()
    {
       
    }


    private void OnDrawGizmosSelected()
    {if(attackPoint!= null)
        {
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }

        
    }
}
