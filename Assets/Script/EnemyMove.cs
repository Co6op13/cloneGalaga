using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 move = new Vector3(0, -1, 0);
        transform.Rotate(180f, 0f, 0f);
        rb.velocity = move * speed;
    }

    void OnBecameInvisible()
    {
        Debug.Log("destroy" + gameObject);
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D something)
    {
        if (something.gameObject.tag == "Player")
        {
            Debug.Log("-----------------------------------");
            Destroy(gameObject);
        }
        if (something.gameObject.tag == "Bullet")
        {
            Debug.Log("-----------++++++++++++------------------------");
            Destroy(gameObject);
        }
    }
}
