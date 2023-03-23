using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 2f;
    private Rigidbody playerRb;

    public float yRange = 14.0f;
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    public bool isLowEnough = false;
    public bool isOnGround = true;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;


 
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

   
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.UpArrow) && !gameOver )
        {
            playerRb.AddForce(Vector3.up * floatForce/3.0f, ForceMode.Impulse);
            
 
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }


    }
    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("ghost"))
        {
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
            explosionParticle.Play();
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("coin"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);
      


        }
        if (other.gameObject.tag == "Ground" && gameOver != true)
        {
            playerRb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);
        }
       

    }

}
