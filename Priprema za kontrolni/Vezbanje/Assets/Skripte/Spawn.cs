using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject spawn;
    public GameObject Kocka;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Kocka == null)
        {
            Kocka = (GameObject)Instantiate(Resources.Load<GameObject>("Sphere"), spawn.transform.position, spawn.transform.rotation);
        }
        if (Kocka.transform.position.y < 15)
        {
            Destroy(Kocka);
        }
	}
 }
