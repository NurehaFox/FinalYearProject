using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTower : MonoBehaviour
{

    private Tower theTower;
    public GameObject projectile;
    public Transform firePoint;
    public float timeBetweenShots = 1f;

    private float shotCounter;

    public Transform target;
    public Transform weaponModel;

    public GameObject shotEffect;
    
    void Start()
    {
        theTower = GetComponent<Tower>();
    }

    // Update is called once per frame
    void Update()
    {

        if(target != null){

           // weaponModel.LookAt(target);
           //Smooth Follow of Target
           weaponModel.rotation = Quaternion.Slerp(weaponModel.rotation, Quaternion.LookRotation(target.position - transform.position), 5f * Time.deltaTime);

            //Lock Rotation so weapon doesn't rotate off the model
           weaponModel.rotation = Quaternion.Euler(0f, weaponModel.rotation.eulerAngles.y, 0f);

        }
        shotCounter -= Time.deltaTime;

        if(shotCounter <= 0 && target != null){

            shotCounter = timeBetweenShots;

            firePoint.LookAt(target);

            Instantiate(projectile, firePoint.position, firePoint.rotation);
            Instantiate(shotEffect, firePoint.position, Quaternion.identity);
        }
        if(theTower.enemiesUpdated){
            //Find Closest enemy and make that the target
        if(theTower.enemiesInRange.Count > 0){
            
            float minDistance = theTower.range + 1f;

            foreach(EnemyController enemy in theTower.enemiesInRange){

                if(enemy != null){

                    float distance = Vector3.Distance(transform.position, enemy.transform.position);

                    if(distance < minDistance){

                        minDistance = distance;
                        target = enemy.transform;
                    }
                }
            }
        }
        else{
            target = null;
        }
    }
    }   
}
