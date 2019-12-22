using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stair3_1 : MonoBehaviour {
    public Transform s;
    // Use this for initialization
    void Start () {
        for (int i = 1; i < 7; i++)
        {
            Transform c = Instantiate(s);
            c.parent = transform;
            c.localPosition = new Vector3(0, -i, -i);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
