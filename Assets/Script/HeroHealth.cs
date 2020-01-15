using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : MonoBehaviour
{
    public int health = 3;

    // Update is called once per frame
    public void TakeDamage(int damage)
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
        Destroy(gameObject);
    }
}
