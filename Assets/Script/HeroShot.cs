using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShot : MonoBehaviour
{
    public GameObject weaponBullet;
    //float speedBullet = 3;
    private float timeBtwShots;
    public float deltaTime = 0.3f;
    

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <=0 && Input.GetButton("Fire1"))
        {
            //weaponBullet.whoShot = "Player";          
            timeBtwShots = deltaTime;
            
            Instantiate(weaponBullet, transform.position, transform.rotation);
           
            // StartCoroutine(NoFire());
        }
        else 
        {
            timeBtwShots -= Time.deltaTime;
        }

    }

    //IEnumerator NoFire() 
    //{
    //    yield return new WaitForSeconds(delayTime);
    //    canShot = true;        
    //}
}
