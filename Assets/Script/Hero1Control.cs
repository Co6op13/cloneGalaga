using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero1Control : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        rb.velocity = move * speed;
    }
}
