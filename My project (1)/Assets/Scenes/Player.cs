using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameManager gameManager;
    public float speed = 10f;
    public Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
       playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameManager.isGameOver == true) {
            return;
        }
        float inputX = Input.GetAxis("Horizontal");

        float inputZ = Input.GetAxis("Vertical");

        float fallspeed = playerRigidbody.velocity.y;

        //playerRigidbody.AddForce(inputX*speed, 0, inputZ*speed);

        Vector3 velocity = new Vector3(inputX, 0, inputZ);

        velocity = velocity*speed;

        velocity.y = fallspeed;
        
        playerRigidbody.velocity = velocity;
    }
}
