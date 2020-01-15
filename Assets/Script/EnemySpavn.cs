using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpavn : MonoBehaviour
{
    public Transform rightPosition;
    public float spavnDelayItem;
    public float spavnDelayEnemy;
    
    public GameObject [] enemyType;
    public GameObject [] itemType;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spavnDelayEnemy, spavnDelayEnemy);
        InvokeRepeating("SpawnItem", spavnDelayItem, spavnDelayItem);
        
    }


    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(transform.position.x, rightPosition.position.x), transform.position.y, 0);
        int i = Random.Range(0, enemyType.Length);
        Instantiate(enemyType[i], spawnPos, transform.rotation);
    }
    void SpawnItem()
    {
        Vector3 spawnPos = new Vector3(Random.Range(transform.position.x, rightPosition.position.x), transform.position.y, 0);
        int j = Random.Range(0, itemType.Length);
        Instantiate(itemType[j], spawnPos, transform.rotation);
    }
  
}
