////////////////////////////
//// Name: Sim McQueen
//// Date: 10/21/2020
//// Desc: Damages something with health on collision with an object
////////////////////////////





using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class DamageOnCollide : MonoBehaviour
{

    [Tooltip("The damage this object does to anything with help")]
    public int Damage = 10;
    [Tooltip("Destroy on Colllide?")]
    public bool DestroyOnCollide = true;
    [Tooltip("Things to do when we collide")]
    public UnityEvent OnCollide = new UnityEvent();

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health otherHealth = collision.gameObject.GetComponent<Health>();
        if(otherHealth != null)
        {
            otherHealth.ChangeHealth(-Damage);
        }
        OnCollide.Invoke();

        if(DestroyOnCollide)
        {
            Destroy(gameObject);
        }


    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
