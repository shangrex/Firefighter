using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_collision : MonoBehaviour {
    //the floor 
    private string position;
    // Use this for initialization
    void Start () {
        position = "1";
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position);
	}
    void OnCollisonEnter(Collider collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (position == "1" && collision.gameObject.tag == "transport")
        {
            Debug.Log("to 2 floor");
            position = "2";
        }

    }
}
