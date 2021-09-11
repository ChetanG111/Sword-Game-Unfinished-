using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMechanics : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NormalSwing()
    {
       Collider[] colliders = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider enemies in colliders)
        {
            Debug.Log("We hit" + enemies.name);
        }
    }

    void Stab()
    {

    }

    void UpAttack()
    {

    }

    void JumpAttack()
    {

    }

    private void OnDrawGizmosSelected()
    {if(attackPoint!= null)
        {
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }

        
    }
}
