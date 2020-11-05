///////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/5/2020
///Description: Fire projectiles
///////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EnemyShoot : MonoBehaviour
{
    [Tooltip("The prefab to be fired - Rigidbody2D needed")]
    public GameObject Projectile;
    [Tooltip("Speed of projectile")]
    public float ProjectileSpeed = 10;
    [Tooltip("Minimum time between projectiles fired in seconds")]
    public float Cooldown = 0.3f;
    float Timer = 0;

    // Update is called once per frame
    void Update()
    {
        // Update timer
        Timer += Time.deltaTime;
        // Check for button press
        if(Input.GetAxisRaw("Jump") > 0)
        {
            // Check if cooldown is over
            if(Timer >= Cooldown)
            {
                // Reset timer
                Timer = 0;
                Shot(transform.position, transform.up);
            }
        }
    }

    void Shot(Vector3 position, Vector3 direction)
    {
        // Create the object and store a link to set velocity
        GameObject proj = Instantiate<GameObject>(Projectile, position, transform.rotation);  

        // Set the velocity
        proj.GetComponent<Rigidbody2D>().velocity = direction * ProjectileSpeed;
        
    }
}
