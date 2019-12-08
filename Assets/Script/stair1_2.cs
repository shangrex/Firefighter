using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stair1_2 : MonoBehaviour
{
    public Transform s;
    // Use this for initialization
    void Start()
    {
        for (int i = 1; i < 4; i++)
        {
            Transform c = Instantiate(s);
            c.parent = transform;
            c.localPosition = new Vector3((-i), i, 0);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
