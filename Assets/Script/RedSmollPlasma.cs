using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSmollPlasma : MonoBehaviour
{
 	public int damage = 1;
	public string[] targetTags = {"Player"};
	


	void OnTriggerEnter2D(Collider2D coll)
	{
					
		foreach(string currentTag in targetTags)
			{	
				if(currentTag == coll.transform.tag)
				{
				Debug.Log("-------------------");		
				coll.transform.GetComponent<HeroHP>().AddDamage(damage);
				Destroy(gameObject);
				}
			}
					
	}

	
}
