/////////////////////////
//// Name: Sim
//// Date: 10/21/2020
//// Desc: Destroy Proj after some time has gone by
/////////////////////////




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtTime : MonoBehaviour
{
    [Tooltip("The time in seconds it takes for the projectile to despawn")]
    public float DeathTime = 3;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeathTimer());
    }

    IEnumerator DeathTimer()
    {


        yield return new WaitForSeconds(DeathTime);
        Destroy(gameObject);



    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
