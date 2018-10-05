using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizScript : MonoBehaviour {
    private bool isClear = false;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void SetClear() {
        isClear = true;
        GetComponent<Animator>().SetBool("isClear", true);
        Debug.Log("SetClear is called");
    }

    public bool GetClear() {
        return isClear;
    }
}
