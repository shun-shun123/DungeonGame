using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanMovementScript : MonoBehaviour {

    private Animator animator;
    private float speed = 3.0f;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow)) {
            animator.SetBool("is_running", true);
            transform.position += transform.forward * speed * Time.deltaTime;
        } else {
            animator.SetBool("is_running", false);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(new Vector3(0, 4, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(new Vector3(0, -4, 0));
        }
	}
}
