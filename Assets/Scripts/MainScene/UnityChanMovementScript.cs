﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class UnityChanMovementScript : MonoBehaviour {
    private static float timeCounter = 0.0f;
    private Animator animator;
    private float speed = 4.0f;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        LaptopPlatformMove();
        SmartphonePlatformMove();
        // タッチを検知する
        TouchInfo touchInfo = AppUtil.GetTouch();
        if (touchInfo == TouchInfo.Began)
        {
            Debug.Log("Touched");
        }
        // Goal時に渡すタイマーカウント
        timeCounter += 1.0f * Time.deltaTime;
	}

    private void LaptopPlatformMove() {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("is_running", true);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool("is_running", false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
    }

    private void SmartphonePlatformMove() {
        float y = CrossPlatformInputManager.GetAxisRaw("Vertical");
        float x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        if (y.Equals(0.0f) && x.Equals(0.0f))
        {
            animator.SetBool("is_running", false);
            return;
        }
        else if (!y.Equals(0.0f))
        {
            animator.SetBool("is_running", true);
        }
        transform.position += transform.forward * y * speed * Time.deltaTime;
        transform.rotation = new Quaternion(0, 1, 0, x * 180);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Goal")) {
            SceneManager.LoadScene("Goal");
        }
    }

    public static int GetTimer() {
        return (int)timeCounter;
    }
}
