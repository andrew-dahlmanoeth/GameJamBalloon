////////////////////////////////////
//// Name: Sim McQueen
//// Date: 11/6/20
//// Desc: A simple shoot script for the bee enemy 
////////////////////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyShootScript : MonoBehaviour
{

    public float speed;
    public bool direction;

    private int Direc;
    




    // Start is called before the first frame update
    void Start()
    {
        
        if(direction)
        {
            Direc = 1;
        } else
        {
            Direc = -1;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x - 10 * Direc, transform.position.y), speed * Time.deltaTime);

        



    }

    


    void DestroyProjectile()
    {
        Destroy(gameObject);
    }


}
