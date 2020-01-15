using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : MonoBehaviour
{
    public float speed = 8;
    public Vector3 move = new Vector3(0, -1, 0);

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    //    transform.Rotate(0, 0f, 180f);
        rb.velocity = move * speed;
    }

    


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            coll.transform.GetComponent<HeroWeapon>().SetWeapon(1);
            Destroy(gameObject);
        }
    }
    
    void OnBecameInvisible()
    {
        
        Destroy(gameObject);
    }
}
