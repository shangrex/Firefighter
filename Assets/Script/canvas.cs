using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

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

    private string[] f;
    private string[] t;
    int fcounter = 0;
    int tcounter = 0;
    public int select_right;

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

        
        string line = "";

        string path = Application.dataPath + @"/Resource/afalse.txt";
        f = new string[100];
        StreamReader reader = new StreamReader(path);
        while ((line = reader.ReadLine()) != null)
        {
            f[fcounter] = line;
            fcounter++;
        }
       



        reader = new StreamReader(path);
        path = Application.dataPath + @"/Resource/aright.txt";
        t = new string[100];
        
        while ((line = reader.ReadLine()) != null)
        {
            Debug.Log(line);
            t[tcounter] = line;
            tcounter++;
        }
        reader.Close();
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

       

        Q_text.text = "下列何者正確？";
        
        select_right = Random.Range(0, 4);
        Debug.Log(select_right);
        if(select_right == 0)
        {
            A_text.text = t[Random.Range(0, tcounter)];
            B_text.text = f[Random.Range(0, fcounter)];
            C_text.text = f[Random.Range(0, fcounter)];
            D_text.text = f[Random.Range(0, fcounter)];
        }
        if (select_right == 1)
        {
            A_text.text = f[Random.Range(0, fcounter)];
            B_text.text = t[Random.Range(0, tcounter)];
            C_text.text = f[Random.Range(0, fcounter)];
            D_text.text = f[Random.Range(0, fcounter)];
        }
        if (select_right == 2)
        {
            A_text.text = f[Random.Range(0, fcounter)];
            B_text.text = f[Random.Range(0, fcounter)];
            C_text.text = t[Random.Range(0, tcounter)];
            D_text.text = f[Random.Range(0, fcounter)];
        }
        if (select_right == 3)
        {
            A_text.text = f[Random.Range(0, fcounter)];
            B_text.text = f[Random.Range(0, fcounter)];
            C_text.text = f[Random.Range(0, fcounter)];
            D_text.text = t[Random.Range(0, tcounter)];
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
