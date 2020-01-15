using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject weaponBullet;
    private float timeBtwShots;
    public float deltaTime = 0.7f;
   



    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            timeBtwShots = deltaTime;
            //transform.Rotate(180f, 0f, 0f);
            Instantiate(weaponBullet, transform.position, transform.rotation);

            // StartCoroutine(NoFire());
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
}
