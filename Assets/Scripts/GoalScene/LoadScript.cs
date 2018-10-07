using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour {
    private int clearTime = 0;
    public Text text;
	// Use this for initialization
	void Start () {
        clearTime = UnityChanMovementScript.GetTimer();
        text.text += clearTime.ToString() + "秒";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadTitle() {
        SceneManager.LoadScene("Title");
    }
}
