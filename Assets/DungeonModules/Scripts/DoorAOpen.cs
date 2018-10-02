using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAOpen : MonoBehaviour
{
    // 最初から空いて欲しい扉はInspectorViewにてチェックを入れる
    public bool canOpen = false;
    public GameObject controller;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        // Triggerの実装
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (canOpen)
        {
            GetComponent<Animator>().SetTrigger("DoorATrigger");
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    public void EnableToOpen() {
        canOpen = true;
    }
}