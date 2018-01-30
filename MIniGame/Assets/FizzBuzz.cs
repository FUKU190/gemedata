using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("デバッグログ");
        FizzBuzzoutput();


    }

    // Update is called once per frame
    void Update()
    {

    }
    void FizzBuzzoutput()
    {
        // public int n = 1
        for (int n = 1; n <= 20; n++)
        {
            if(n % 3 == 0 && n % 5== 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if(n % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if(n % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(n);
            }
        }

    }
}
