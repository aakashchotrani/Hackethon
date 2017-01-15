using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButton("Jump"))
        {
            //  Debug.Log("hello");
            Application.LoadLevel("TestLevel/testscene");
        }
		
	}
}
