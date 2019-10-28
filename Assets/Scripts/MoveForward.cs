using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float waterPerSecond = 5;
    public GameObject water;
    bool canShoot = true;

    void Start()
    {
        
    }

    
    void Update()
    {
        Instantiate(water, transform.position, transform.rotation);
        canShoot = false;

        Invoke("EnableWater", 1 / waterPerSecond);
    }

    void EnableWater()
    {
        canShoot = true;
    }

}
