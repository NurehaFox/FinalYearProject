using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float speed;  
    NavMeshAgent agent;  

    public float attackDelay;
    public float attackCooldown;
    public float damage;

    public Transform Castleobj;
    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();

        attackCooldown = attackDelay;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Castleobj.position * speed);

        //if NAvmesh gets weithin range stop and attack
        
    /*    else{
            attackCooldown -= Time.deltaTime;
            if(attackCooldown <= 0){
                
                attackCooldown = attackDelay;
                
                Castle.TakeDamage(damage);
            }
            
        }
        */
    }
}
