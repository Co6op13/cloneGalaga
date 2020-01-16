using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero1Control : MonoBehaviour
{
    public float speed = 5;
    private Camera cam;
    private float topCam,downCam;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>(); //Камера на основе которой будем определять вышел ли объект за ее границы
        Vector3 point = cam.WorldToViewportPoint(transform.position); //Записываем положение объекта к границам камеры, X и Y это будут как раз верхние и нижние границы камеры
        if(point.y < 0f || point.y > 1f || point.x > 1f || point.x < 0f) { //Если объект вышел за одну из этих границ, тут именно 0 и 1 это границы камеры. Но можно выйти и за эти значения, если указать например -0.2f
    //нужный код
}



        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = cam.WorldToViewportPoint(transform.position); //Записываем положение объекта к границам камеры, X и Y это будут как раз верхние и нижние границы камеры
        if(point.y < 0f || point.y > 1f || point.x > 1f || point.x < 0f)
         { //Если объект вышел за одну из этих границ, тут именно 0 и 1 это границы камеры. Но можно выйти и за эти значения, если указать например -0.2f
            //нужный код

            Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
            rb.velocity = move * speed;
        }
    }
}
