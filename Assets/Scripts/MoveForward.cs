using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    
    [SerializeField] GameObject water;
    

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(water, transform.position, transform.rotation);
        }

        
    }

   
}
