//////////////////////
///Name: Andrew Dahlman-Oeth
///Date: 11/3/2020
///Description: The spawn function is stored here to be used by Unity Events from other scripts.
//////////////////////
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFunction2 : MonoBehaviour
{
    [Tooltip("This is an array of game objects that spawn from spawn function")]
    public GameObject[] ObjectsToSpawn;
    // This function is built to be used by other scripts - requires public
    public void Spawn()
    {
        for(int i = 0; i < ObjectsToSpawn.Length; ++i)
        {
            // Spawn each object here where the other object was
            Instantiate(ObjectsToSpawn[i], transform.position, Quaternion.identity);
            
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
