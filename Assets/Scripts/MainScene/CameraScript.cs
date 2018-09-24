using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    public GameObject target;
    private Vector3 bias;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.rotation = target.transform.rotation;
        bias = target.transform.forward * -2.0f + target.transform.up * 2.0f;
        transform.position = target.transform.position + bias;
	}
}
