using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        iTween.MoveAdd(gameObject, iTween.Hash("y", 1f, "time", 10.0f, "looptype", "pingpong"));
        // transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 0.7f), transform.position.z);
    }
}
