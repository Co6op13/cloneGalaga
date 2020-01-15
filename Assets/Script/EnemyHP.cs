using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int hp = 2;
    // Start is called before the first frame update
    public void AddDamage (int damage)
    {
        hp -= damage;
        if (hp<= 0)
        {
            Destroy(gameObject);
        }
    }
}
