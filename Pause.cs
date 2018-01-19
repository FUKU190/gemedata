using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public bool stopTime;
    public GameObject ui;
    private GameObject obj;
    public CanvasGroup Pausecanvas;
    public CanvasGroup Maincanvas;

	// Use this for initialization
	void Start () {
        stopTime = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Gamestop()
    {
        //メニューボタンを押すとポーズ画面になり、時間が停止する。
       
        if (!stopTime)
        {
            obj = Instantiate(ui);
            Time.timeScale = 0;
            Pausecanvas.alpha = 1;
            Maincanvas.alpha = 0;
        }
        else
        {
            Time.timeScale = 1;
            Pausecanvas.alpha = 0;
            Maincanvas.alpha = 1;
            Destroy(obj);
           
        }
        stopTime = !stopTime;
    }
}
