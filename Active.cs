using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Active : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public Button button1;
    public Text ResultScoreText;
   
    // Use this for initialization
    void Start()
    {
        canvasGroup.alpha = 0;
        //        button1.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider hit)
    {
        //ゴールタグに触れるとスコア表示
        if (hit.CompareTag("Goal"))
        {
            
          
            canvasGroup.alpha = 1;
            ResultScoreText.text = "Score:"+GameObject.Find("unitychan").GetComponent<Item>().score.ToString();

           


        }
    }
}