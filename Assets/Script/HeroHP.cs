using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHP : MonoBehaviour
{
   public int health = 3;

    // Update is called once per frame
    public void AddDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
     
    void Die()
    {
        Debug.Log(gameObject.name+"-------------------------------");
        gameObject.GetComponent<Rigidbody2D>().transform.position = new Vector3(0,0,0);
        //Destroy(gameObject);
        gameObject.GetComponent<HeroWeapon>().SetWeapon(-1);
        health = 3;
    }
}
