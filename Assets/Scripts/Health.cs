//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/3/2020
///Description: Add to a Game Object to give it health. Includes the OnDeath function.
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [Tooltip("The max health of the object")]
    public float MaxHealth = 100;
    [Tooltip("The current health of the object")]
    public float CurrentHealth = 100;
    [Tooltip("Whether or not to destroy object when object has no health")]
    public bool DestroyAtZero = true;
    public UnityEvent OnDeath;

    public void ChangeHealth(int change)
    {
        CurrentHealth += change;

        if(CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }

        if(CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            OnDeath.Invoke();
            if(DestroyAtZero)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnCollisioEnter2D()
    {
        if(collision.gameObject.CompareTag("Bee"))
        {
            CurrentHealth -= 10
        }
    }
}
