using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput; 
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float zMin = -10;
    public float zMax= 10;
    public float zverticalInput;
  

    public Transform projectileSpawnPoint;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //keep player inbounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        // Get player to move 
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  verticalInput * Time.deltaTime * speed);

       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

        }
    }
    }

