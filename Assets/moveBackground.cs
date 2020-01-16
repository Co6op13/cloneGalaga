using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour
{
    public float speed=-10f;
    public float startPos = 92.4f;
    public float stopPos = -112.4f;
	
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0f,speed * Time.deltaTime,0f));
		if (transform.position.y < stopPos) 
		{
			transform.position=new Vector3(0f,startPos,0f);
		}
	}
}
