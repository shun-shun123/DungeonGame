using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject target;
    private Vector3 positionBias;
    private Vector3 rotateBias;
    private bool isUp = false;
    private bool isDown = false;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        ButtonControll();
        transform.rotation = target.transform.rotation;
        transform.Rotate(new Vector3(20.0f, 0, 0));
        transform.Rotate(rotateBias);
        positionBias = target.transform.forward * -2.0f + target.transform.up * 2.0f;
        transform.position = target.transform.position + positionBias;
	}

    void ButtonControll() {
        if (isUp) {
            UpCamera();
        }
        if (isDown) {
            DownCamera();
        }
    }

    public void UnableUpCamera() {
        isUp = false;
    }

    public void EnableUpCamera() {
        isUp = true;
    }

    public void UnableDownCamera() {
        isDown = false;
    }
    public void EnableDownCamera() {
        isDown = true;
    }

    void UpCamera() {
        rotateBias += new Vector3(-0.6f, 0, 0);
    }
    void DownCamera() {
        rotateBias += new Vector3(0.6f, 0, 0);
    }
}
