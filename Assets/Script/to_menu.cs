using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
    public void click()
    {
        Debug.Log("to menu");
        //Scene cur = SceneManager.GetActiveScene();
        SceneManager.LoadScene(1);
    }
}
