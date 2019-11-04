using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] float rotationSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    [SerializeField] GameObject projectilePrefab;
    private Animator playerAnim;

    [SerializeField] Text scoreText;
    int score = 0;

    [SerializeField] ParticleSystem splash;

    [SerializeField] AudioClip splashSound;
    AudioSource playerAudio;
    

    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * rotationSpeed;
        forwardInput = Input.GetAxis("Vertical") * speed;
        horizontalInput *= Time.deltaTime;
        forwardInput *= Time.deltaTime;

        transform.Translate(0, 0, forwardInput);
        transform.Rotate(0, horizontalInput, 0);

        if (forwardInput != 0)
        { 
            playerAnim.SetBool("IsWalking", true);
        }
        else
        {
            playerAnim.SetBool("IsWalking", false);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
    
 
    public void UpdateScoreG()
    { 
        score++;
        scoreText.text = "Score: " + score;

    }
    public void UpdateScoreB()
    {
        score--;
        scoreText.text = "Score: " + score;
    }

    public void Splash()
    {
        splash.Play();
        playerAudio.PlayOneShot(splashSound, 1.0f);
    }
}
