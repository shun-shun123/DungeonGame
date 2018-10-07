using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour {
    private Animator animator;
    private int state = 1;
    private float pastTime = 0.0f;
	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        pastTime += Time.deltaTime;
        if (pastTime > 5.0f)
        {
            state = Random.Range(1, 5);
            animator.SetInteger("state", state);
            pastTime = 0.0f;
            Debug.Log("state: " + state);
        }
    }
}
