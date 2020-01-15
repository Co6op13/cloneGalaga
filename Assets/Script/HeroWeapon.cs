using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWeapon : MonoBehaviour
{
    //public GameObject shooter;
    public float speed;
    public GameObject[] spawnPoint;
    public GameObject[] typeWeapon;
    public float reloadWeapon = 0.3f;
    private float timeBtwShots;
    public int weaponNumber = 0;
   // Start is called before the first frame update

void Start ()
{
   // shooter = GetComponent<GameObject>();
}
    public void SetWeapon (int i)
    {
        //если смерть героя то присылаеться -1 если поднял итем то +1
        Debug.Log(weaponNumber+" ---"+ i +"   --" + typeWeapon.Length);
        if (i > 0 && weaponNumber < typeWeapon.Length-1)
            weaponNumber += i;
        else if (i < 0 && weaponNumber >0)
            weaponNumber += i;

            
    }

        void GenerationBullet(int dulo)
    {
        //позиция появления 
        Vector3 bulletPosition = spawnPoint[dulo].transform.position;
        
        

        float x = spawnPoint[dulo].transform.position.x - transform.position.x;
        float y = spawnPoint[dulo].transform.position.y - transform.position.y;
        // куда будем толкать
        Vector2 bulletForce = new Vector2(x, y);

        GameObject createBullet = Instantiate(typeWeapon[weaponNumber], bulletPosition, transform.rotation) as GameObject;
        createBullet.GetComponent<Rigidbody2D>().AddForce(bulletForce * speed, ForceMode2D.Impulse);
        createBullet.transform.SetParent(gameObject.transform);
    }
    void Update()
    {
        if (timeBtwShots <= 0 && Input.GetButton("Fire1"))
        {
            //weaponBullet.whoShot = "Player";          
            timeBtwShots = reloadWeapon;
            GenerationBullet(0);        
            // StartCoroutine(NoFire());
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }


}
