using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {

    public float delayTime = 0.5f;
    public float fireRange = 30.0f;
    private float fireRate = 0;
    public int Bullets = 20;
    public AudioSource playerAudioSource;
    // Use this for initialization
    void Start ()
    {
        playerAudioSource = this.GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && fireRate > 1.0f && Bullets > 0)
        {
            Debug.Log("Fire");
            Bullets--;
            fireRate = 0;
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, fireRange))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.tag == "Enemy")
                {
                    hit.collider.GetComponent<Enemy>().isAlive = false;
                }
            }
            playerAudioSource.Play();
            Debug.Log("Shoot audio");

        }
        fireRate += Time.deltaTime;


    }
}
