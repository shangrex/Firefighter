using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_review : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void click()
    {
        //Scene cur = SceneManager.GetActiveScene();
        gameObject.SetActive(true);
    }
}
