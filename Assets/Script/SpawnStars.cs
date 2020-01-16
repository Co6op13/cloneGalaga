using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
   public float speed = -0.01f;
   public float teleport = 10f;
 
    
    void Update ()
    {
        transform.Translate (new Vector3 (0f,speed,0f));
        if (transform.position.y < teleport)
        {   
            transform.position = new Vector3(0f,30f,0f);
        }
    }

}
