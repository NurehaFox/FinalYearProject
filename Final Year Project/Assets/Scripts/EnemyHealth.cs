using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public float totalHealth;

    public Slider healthBar;

    public int money = 50;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.maxValue = totalHealth;
        healthBar.value = totalHealth;
    }

    // Update is called once per frame
    void Update()
    {
      //  healthBar.transform.rotation = Camera.main.transform.rotation;
    }

    public void TakeDamage(float damage){

        totalHealth -= damage;

        if(totalHealth <= 0){

            totalHealth = 0;

            Destroy(gameObject);     

            MoneyManager.instance.GiveMoney(money);
        }

         healthBar.value = totalHealth;
         healthBar.gameObject.SetActive(true);
    }
}
