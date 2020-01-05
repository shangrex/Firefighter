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

    private List<string> f;
    private List<string> t;
    private List<string> c;
    //private string[] f;
    //private string[] t;
    private string[] stair_question;
    private string[] stair_false;
    private string[] stair_true;
    int fcounter = 0;
    int tcounter = 0;
    int stair_q_counter = 0;
    int stair_f_counter = 0;
    int stair_t_counter = 0;
    public int select_right;
    public TextAsset aright;
    public TextAsset afalse;
    public TextAsset condition;

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
        f = new List<string>();
        t = new List<string>();
        string[] aright_array = aright.text.Split('\n');
        foreach(var i in aright_array)
        {
            t.Add(i);
            
        }
        string[] afalse_array = afalse.text.Split('\n');
      
        foreach( var i in afalse_array)
        {
            f.Add(i);
        }
        string[] condition_array = condition.text.Split('\n');
        c = new List<string>();
        foreach(var i in condition_array)
        {
            c.Add(i);
        }

        
        /*
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
        */
    }

    public void startquestion()
    {
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

       

        Q_text.text = "下列何者正確？";
        
        select_right = Random.Range(0, 4);
        Debug.Log(select_right);
        
        if(select_right == 0)
        {
            
            A_text.text = "1 " + t[Random.Range(0, t.Count - 1)];
            B_text.text = "2 " + f[Random.Range(0, f.Count - 1)];
            C_text.text = "3 "+ f[Random.Range(0, f.Count - 1)];
            D_text.text = "4 " + f[Random.Range(0, f.Count - 1)];
            
        }
        if (select_right == 1)
        {
            
            A_text.text = "1 " + f[Random.Range(0, f.Count - 1)];
            B_text.text = "2 " + t[Random.Range(0, t.Count - 1)];
            C_text.text = "3 " + f[Random.Range(0, f.Count - 1)];
            D_text.text = "4 " + f[Random.Range(0, f.Count - 1)];
            
        }
        if (select_right == 2)
        {
            
            A_text.text = "1 " + f[Random.Range(0, f.Count - 1)];
            B_text.text = "2 " + f[Random.Range(0, f.Count - 1)];
            C_text.text = "3 " + t[Random.Range(0, t.Count - 1)];
            D_text.text = "4 " + f[Random.Range(0, f.Count - 1)];
            
        }
        if (select_right == 3)
        {
            
            A_text.text = "1 " + f[Random.Range(0, f.Count - 1)];
            B_text.text = "2 " + f[Random.Range(0, f.Count - 1)];
            C_text.text = "3 " + f[Random.Range(0, f.Count - 1)];
            D_text.text = "4 " + t[Random.Range(0, t.Count - 1)];
            
        }
        

    }

    public void condition_quesiton(string tag)
    {
        background.sprite = red;
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
            int select = 0;
            string[] condition_text = c[select].Split(':');
            select_right = Random.Range(2, 6) - 2;
            Debug.Log(select_right);
            Q_text.text = condition_text[1];

            if (select_right == 0)
            {

                A_text.text = "1 " + condition_text[2];
                B_text.text = "2 " + condition_text[3];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 1)
            {

                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[2];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 2)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[2];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 3)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[5];
                D_text.text = "4 " + condition_text[2];

            }
        }
        if(tag == "condition_bathroom")
        {
            int select = 1;
            string[] condition_text = c[select].Split(':');
            select_right = Random.Range(2, 6) - 2;
            Debug.Log(select_right);
            Q_text.text = condition_text[1];

            if (select_right == 0)
            {

                A_text.text = "1 " + condition_text[2];
                B_text.text = "2 " + condition_text[3];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 1)
            {

                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[2];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 2)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[2];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 3)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[5];
                D_text.text = "4 " + condition_text[2];

            }

        }
        if (tag == "condition_kitchen")
        {
            int select = 2;
            string[] condition_text = c[select].Split(':');
            select_right = Random.Range(2, 6) - 2;
            Debug.Log(select_right);
            Q_text.text = condition_text[1];

            if (select_right == 0)
            {

                A_text.text = "1 " + condition_text[2];
                B_text.text = "2 " + condition_text[3];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 1)
            {

                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[2];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 2)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[2];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 3)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[5];
                D_text.text = "4 " + condition_text[2];

            }

        }
        if (tag == "condition_bathroom2")
        {
            int select = 3;
            string[] condition_text = c[select].Split(':');
            select_right = Random.Range(2, 6) - 2;
            Debug.Log(select_right);
            Q_text.text = condition_text[1];

            if (select_right == 0)
            {

                A_text.text = "1 " + condition_text[2];
                B_text.text = "2 " + condition_text[3];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 1)
            {

                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[2];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 2)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[2];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 3)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[5];
                D_text.text = "4 " + condition_text[2];

            }

        }
        if (tag == "condition_hydra")
        {
            int select = 4;
            string[] condition_text = c[select].Split(':');
            select_right = Random.Range(2, 6) - 2;
            Debug.Log(select_right);
            Q_text.text = condition_text[1];

            if (select_right == 0)
            {

                A_text.text = "1 " + condition_text[2];
                B_text.text = "2 " + condition_text[3];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 1)
            {

                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[2];
                C_text.text = "3 " + condition_text[4];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 2)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[2];
                D_text.text = "4 " + condition_text[5];

            }
            if (select_right == 3)
            {


                A_text.text = "1 " + condition_text[3];
                B_text.text = "2 " + condition_text[4];
                C_text.text = "3 " + condition_text[5];
                D_text.text = "4 " + condition_text[2];

            }

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
