using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnInterval = 1.0f;
    private float cooldown;
    private float timer = 0;
    private float initialCooldown;



    void Start()
    {
        cooldown = initialCooldown;
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer>cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = spawnInterval; // setting cooldown to actual spawn interval
            timer = 0;// reset timer
        }

    }
}
