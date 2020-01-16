using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{


    private float test; 
    public float bulletSpeed;
    public GameObject [] spawnPoint;
    public GameObject bullet;
    public float reloadWeapon = 0.3f;
    private float timeBtwShots;
    // Start is called before the first frame update

    void GenerationBullet()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
        //позиция появления 
        Vector3 bulletPosition = spawnPoint[i].transform.position;



        float x = spawnPoint[i].transform.position.x - transform.position.x;
        float y = spawnPoint[i].transform.position.y - transform.position.y;
        // куда будем толкать
        Vector2 bulletForce = new Vector2(x, y);
        GameObject createBullet = Instantiate(bullet, bulletPosition, transform.rotation) as GameObject;
        createBullet.GetComponent<Rigidbody2D>().AddForce(bulletForce * bulletSpeed, ForceMode2D.Impulse);
        createBullet.transform.SetParent(gameObject.transform);
        }   
    }
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            timeBtwShots = reloadWeapon;
            //transform.Rotate(180f, 0f, 0f);
            GenerationBullet();

            // StartCoroutine(NoFire());
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
