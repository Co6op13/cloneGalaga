using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{

    public Transform rightPosition;
    public float spavnDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spavnDelay, spavnDelay);
        
    }


    
}
