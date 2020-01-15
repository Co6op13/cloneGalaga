using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGausSmoll : MonoBehaviour
{
	public int damage = 1;
	public string[] targetTags = {"Enemy", "Bomb"};
	


	void OnTriggerEnter2D(Collider2D coll)
	{
					
		foreach(string currentTag in targetTags)
			{	
				if(currentTag == coll.transform.tag)
				{
				Debug.Log("-------------------");		
				coll.transform.GetComponent<EnemyHP>().AddDamage(damage);
				Destroy(gameObject);
				}
			}
					
	}

	void OnBecameInvisible()
    {
        
        Destroy(gameObject);
    }

	
}