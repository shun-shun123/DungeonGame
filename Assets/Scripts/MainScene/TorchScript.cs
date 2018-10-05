using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour {
    public List<GameObject> torches;
    private bool animStart = false;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < torches.Count; i++) {
            torches[i].gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (animStart)
        {
            StartCoroutine(LightUp());
        }
	}

    public void SetAnimStart() {
        animStart = true;
    }

    IEnumerator LightUp() {
        int i = 0;
        while (i < torches.Count)
        {
            yield return new WaitForSeconds(0.5f);
            ActivateTorce(i);
            i += 2;
        }
        animStart = false;
    }
    void ActivateTorce(int index) {
        torches[index].gameObject.SetActive(true);
        torches[index + 1].gameObject.SetActive(true);
    }
}
