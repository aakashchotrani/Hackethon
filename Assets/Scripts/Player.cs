using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


   

    public int PlayerHealth;
	// Use this for initialization
	void Start ()
    {

        PlayerHealth = 100;	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (PlayerHealth <= 0)
        {
            Application.LoadLevel("Game Over");
        }
		
	}



  

}
