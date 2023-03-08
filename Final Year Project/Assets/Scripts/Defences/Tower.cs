using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public float range = 3;
    public LayerMask whatIsEnemy;

    Collider[] collidersInRange;
    public List<EnemyController> enemiesInRange = new List<EnemyController>();

    public float checkCounter;
    [SerializeField]
     float checkTime = .2f;

     [HideInInspector]
    public bool enemiesUpdated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        enemiesUpdated = false;
        
        checkCounter -= Time.deltaTime;

        if(checkCounter <= 0)
        {
            checkCounter = checkTime;

            collidersInRange = Physics.OverlapSphere(transform.position, range, whatIsEnemy);

            enemiesInRange.Clear();
            foreach(Collider col in collidersInRange)
            {
             enemiesInRange.Add(col.GetComponent<EnemyController>());
            }

            enemiesUpdated = true;
        }

    }
}
