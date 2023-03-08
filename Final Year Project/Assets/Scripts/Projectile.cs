using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


[SerializeField]
     Rigidbody rb;
    public float moveSpeed;

    public GameObject impactEffect;

    public float damageAmount;

    bool hasDamaged;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * moveSpeed;
    }

    void OnTriggerEnter(Collider other){

        if(other.tag == "Enemy" && !hasDamaged){

            other.GetComponent<EnemyHealth>().TakeDamage(damageAmount);
            hasDamaged = true;
        }

        Instantiate(impactEffect, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }

}
