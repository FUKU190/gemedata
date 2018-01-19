using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Item : MonoBehaviour {
    public Text scoretext;
   public int score = 0;
    public AudioClip BallGet;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal =
            Input.GetAxis("Horizontal");
        float moveVertical =
            Input.GetAxis("Vertical");

        Vector3 movement = new
            Vector3(moveHorizontal, 0.0f, moveVertical);
	}
     void OnTriggerEnter(Collider hit)
    {
        //ボールタグに触れるとスコア+100
        if (hit.CompareTag("Ball"))
        {
            Destroy(hit.gameObject);
            AudioSource.PlayClipAtPoint(BallGet, transform.position);
            score += 100;
            scoretext.text= "Score:"+score.ToString();
            
        }
    }
}
