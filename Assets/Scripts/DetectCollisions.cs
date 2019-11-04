using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    
    
    PlayerController playerController;

    private void Start()
    {
        GameObject playerControllerObject = GameObject.FindWithTag("Player");
        if(playerControllerObject != null)
        {
            playerController = playerControllerObject.GetComponent<PlayerController>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("GoodPlant"))
        {
          
            Destroy(gameObject);
            playerController.UpdateScoreG();
            playerController.Splash();
            Destroy(other.gameObject);
            
            
        }
        else if (gameObject.CompareTag("BadPlant"))
        {
            Destroy(gameObject);
            playerController.UpdateScoreB();
            playerController.Splash();
            Destroy(other.gameObject);
        }
        
    }
}
