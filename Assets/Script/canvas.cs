using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class canvas : MonoBehaviour {
    public Image background;
    public Sprite red;
    public Sprite blue;
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
    private string[] stair_question;
    private string[] stair_false;
    private string[] stair_true;
    int fcounter = 0;
    int tcounter = 0;
    int stair_q_counter = 0;
    int stair_f_counter = 0;
    int stair_t_counter = 0;
    public int select_right;

    // Use this for initialization
    void Start () {
        background = gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
        background.sprite = blue;
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
        reader = new StreamReader(path);
        while ((line = reader.ReadLine()) != null)
        {  
            t[tcounter] = line;
            tcounter++;
        }

        path = Application.dataPath + @"/Resource/condition.txt";
        reader = new StreamReader(path);
        stair_question = new string[10];
        stair_false = new string[10];
        stair_true = new string[10];
        while((line = reader.ReadLine()) != null)
        {
            string[] word = line.Split(' ');
            foreach(var i in word){
                Debug.Log(i);
            }
            if (word[0] == "stair_question:")
            {
                stair_question[stair_q_counter] = word[1];
                stair_q_counter++;
            }
            else if(word[0] == "stair_right:")
            {
                stair_true[stair_t_counter] = word[1];
                stair_t_counter++;
            }
            else if(word[0] == "stair_false:")
            {
                stair_false[stair_f_counter] = word[1];
                stair_f_counter++;
            }
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

    public void condition_quesiton(string tag)
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

        if (tag == "condition_stair")
        {
            select_right = 0;
            Q_text.text = stair_question[Random.Range(0, stair_q_counter)];
            A_text.text = stair_true[Random.Range(0, stair_t_counter)];
            B_text.text = stair_false[0];
            C_text.text = stair_false[1];
            D_text.text = stair_false[2];
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
