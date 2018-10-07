using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour{
    public List<GameObject> door = new List<GameObject>();
    public GameObject[] quizes = new GameObject[3];
    public Camera camera;
    public Canvas quizCanvas;
    public GameObject Recticle;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        CallEnableToOpen();
    }

    public void CallEnableToOpen() {
        for (int i = 0; i < 3; i++) {
            if (!quizes[i].GetComponent<QuizScript>().GetClear()) {
                return;
            }
        }
        for (int i = 0; i < door.Count; i++)
        {
            door[i].SendMessage("EnableToOpen");
            Debug.Log("Doorが開きます");
        }
    }

    public void RayCast()
    {
        Vector3 center = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = camera.ScreenPointToRay(center);
        RaycastHit hit;
        int distance = 500;
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red, 3, true);
        if (Physics.Raycast(ray, out hit, distance))
        {
            if (hit.collider.gameObject.CompareTag("Quiz") && (hit.collider.gameObject == quizes[0] || hit.collider.gameObject == quizes[1] || hit.collider.gameObject == quizes[2]))
            {
                QuestionMaker.quizBox = hit.collider.gameObject;
                QuestionMaker.objectName = hit.collider.gameObject.name;
                QuestionMaker.room = this.gameObject;
                quizCanvas.gameObject.SetActive(true);
                Recticle.gameObject.SetActive(false);
            }
        }
    }
}
