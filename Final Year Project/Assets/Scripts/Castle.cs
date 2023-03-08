using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Castle : MonoBehaviour
{
    public float maxHealth = 100;
    [SerializeField]
    float currentHealth;

    public Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Take damage
    public void TakeDamage(float damage)
    {
        
        currentHealth -= damage;
        
        if(currentHealth >= 0){
            gameObject.SetActive(false);
        }

        healthSlider.value = currentHealth;
    }
}
