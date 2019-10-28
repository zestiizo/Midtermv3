using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float rotationSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    
    [SerializeField] GameObject projectilePrefab;
    private Animator playerAnim;
   
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal")*rotationSpeed;
        forwardInput = Input.GetAxis("Vertical")*speed;
       horizontalInput *= Time.deltaTime;
       forwardInput *= Time.deltaTime;

        transform.Translate(0, 0, forwardInput);
        transform.Translate(0, horizontalInput, 0);

        if(forwardInput != 0)
        {
            playerAnim.SetBool("IsWalking", true);
        }
       else
       {
            playerAnim.SetBool("IsWalking", false);
       }

        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       // transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
          Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
}
