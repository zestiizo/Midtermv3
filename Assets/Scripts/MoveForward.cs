using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] float speed = 40;
    void Start()
    {
        
    }

    
    void Update()
    {
       //gameObject.transform.position = transform.position + Camera.main.transform.forward * 2;
       //Rigidbody rb = gameObject.GetComponent<Rigidbody>();
       //rb.velocity = Camera.main.transform.forward * 40;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
