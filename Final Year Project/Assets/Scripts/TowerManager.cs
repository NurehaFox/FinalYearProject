using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{

    public static TowerManager instance;

    public Tower activeTower;
    public Transform indicator;
    public bool isPlacing;

    public LayerMask whatIsGround;

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
        if(isPlacing){

            indicator.position = GetGridPosition();
        }

        //Place Tower
        if(Input.GetMouseButtonDown(0)){

            isPlacing = false;

            Instantiate(activeTower, indicator.position, activeTower.transform.rotation);

            indicator.gameObject.SetActive(false);

        }
    }

    public void StartTowerPlacement(Tower towerToPlace)
    {
            activeTower = towerToPlace;
            
            isPlacing = true;

            indicator.gameObject.SetActive(true);

          
            
    }

    public Vector3 GetGridPosition(){

        Vector3 location = Vector3.zero;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction * 200f, Color.red);

    //    RaycastHit hit;
      //  if(Physics.Raycast(ray, out hit, 200f, whatIsGround)){

      //      location = hit.point;
      //  }

      //  location.y = 0f;

        return location;

    }
    }