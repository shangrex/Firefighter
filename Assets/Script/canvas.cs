using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvas : MonoBehaviour {

    GameObject Q;
    GameObject A;
    GameObject B;
    GameObject C;
    GameObject D;
    private Text Q_text;
    private Text A_text;
    private Text B_text;
    private Text C_text;
    private Text D_text;

    // Use this for initialization
    void Start () {
        
        Q = gameObject.transform.GetChild(1).gameObject;
        A = gameObject.transform.GetChild(2).gameObject;
        B = gameObject.transform.GetChild(3).gameObject;
        C = gameObject.transform.GetChild(4).gameObject;
        D = gameObject.transform.GetChild(5).gameObject;
        Q_text = Q.GetComponent<Text>();
        A_text = A.GetComponent<Text>();
        B_text = B.GetComponent<Text>();
        C_text = C.GetComponent<Text>();
        D_text = D.GetComponent<Text>();
        gameObject.SetActive(false);
    }

    public void startquestion()
    {
        Q = gameObject.transform.GetChild(1).gameObject;
        A = gameObject.transform.GetChild(2).gameObject;
        B = gameObject.transform.GetChild(3).gameObject;
        C = gameObject.transform.GetChild(4).gameObject;
        D = gameObject.transform.GetChild(5).gameObject;
        Q_text = Q.GetComponent<Text>();
        A_text = A.GetComponent<Text>();
        B_text = B.GetComponent<Text>();
        C_text = C.GetComponent<Text>();
        D_text = D.GetComponent<Text>();


        Q_text.text = "hello world";
        Debug.Log("hello world");
        Q_text.text = Random.Range(0, 10).ToString();
        /*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject p = gameObject.transform.GetComponentInParent<GameObject>();
            p.gameObject.SetActive(true);
        }
        */
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
