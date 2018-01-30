using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    int num;
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public Transform SpawnPoint;

	// Use this for initialization
	void Start () {

        

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(cube, SpawnPoint);
        }
		
	}
}
