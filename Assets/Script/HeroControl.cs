using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour
{
    public float HeroSpeed = 4;

    private Rigidbody2D rb2dHero;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb2dHero = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * HeroSpeed;

    }

    void FixedUpdate()
    {
        rb2dHero.MovePosition(rb2dHero.position + moveVelocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}