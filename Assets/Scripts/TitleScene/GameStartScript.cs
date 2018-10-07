using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartScript : MonoBehaviour {
    private AsyncOperation async;
    public GameObject LoadingUi;
    public Slider slider;
    public GameObject TitleUi;
    public GameObject Toggle;
    // Use this for initialization
	void Start () {
        LoadingUi.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void OnClick() {
        TitleUi.SetActive(false);
        LoadingUi.SetActive(true);
        CameraScript.isFps = Toggle.GetComponent<Toggle>().isOn;
        StartCoroutine(GameStart());
    }

    IEnumerator GameStart() {
        async = SceneManager.LoadSceneAsync("Main");
        while (!async.isDone) {
            slider.value = async.progress;
            yield return true;
        }
    }
}
