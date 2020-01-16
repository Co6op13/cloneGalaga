using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxLayer : MonoBehaviour
{
 
	private float length, startpos;
	public GameObject cam;
	public float paralaxEffect;

/*	void Start () 
	{
		startpos = transform.position.y;
		length = GetComponent<SpriteRenderer>().bounds.size.y;	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		float dist = cam.transform.position.y * paralaxEffect;
		transform.position = new Vector3 (transform.position.x, startpos + dist,transform.position.z);
	}*/
}
