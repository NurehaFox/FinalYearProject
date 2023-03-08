using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    public int currentMoney;

    void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveMoney(int amountToGive){

        currentMoney += amountToGive;
    }

    public bool SpendMoney(int amountToSpend){

        bool canSpend = false;

        if(amountToSpend <= currentMoney){
            
            canSpend = true;

            Debug.Log("spent" + amountToSpend);
            currentMoney -= amountToSpend;
        }

        return canSpend;
    }
}
