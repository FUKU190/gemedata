using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primenumbers : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("デバッグログ");
        Primenumbersout();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Primenumbersout()
    {
        for(int n = 2; n <= 101; n++){
            if (n / 2 == 1)
            {
                Debug.Log(n);
            }
             if(n / 3 == 1)
            {
                Debug.Log(n);
            }
        }
    }
}
