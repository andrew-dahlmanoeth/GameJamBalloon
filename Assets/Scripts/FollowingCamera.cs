///////////////////////
//// Name: Sim McQueen
//// Date: 10/20/2020
//// Desc: Camera that follows the player
///////////////////////



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [Tooltip("What the camera will follow")]
    public GameObject Target;

    [Tooltip("How 'Smooth' the camera will be (0-1)")]
    public float Smoothing = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Target != null)
        {
            if(GlobalVarStorage.levelOnGoing)
            {
                // retrive and save the pos
                Vector3 newPos = Target.transform.position;
                // adjust the z value back to the camera's normal height
                newPos.z = transform.position.z;
                // linear interpolate towards the target location
                transform.position = Vector3.Lerp(transform.position, newPos, Smoothing);
            }
            
        }
    }
}
