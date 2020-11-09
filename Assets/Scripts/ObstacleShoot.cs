using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleShoot : MonoBehaviour
{

    private float TimeBtwShots;
    public float startTimeBtwShots;
    public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {

        TimeBtwShots = startTimeBtwShots;

    }

    // Update is called once per frame
    void Update()
    {
        if(TimeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            TimeBtwShots = startTimeBtwShots;


        } else
        {
            TimeBtwShots -= Time.deltaTime;
        }



    }
}
