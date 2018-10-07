using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionMaker : MonoBehaviour {
    private static Questions questions = new Questions();
    public static GameObject quizBox;
    public static GameObject room;
    public GameObject Recticle;
    public static string objectName;
    public Canvas quizCanvas;
    public InputField inputText;
    public Text question;
    private int index = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        index = questions.GetIndexFromQuestionBox(objectName);
        question.text = Questions.questions[index];
    }

    public void CheckAnswer() {
        if (Questions.answers[index] == inputText.text)
        {
            quizBox.GetComponent<QuizScript>().SetClear();
            room.GetComponent<Controller>().CallEnableToOpen();
        }
        quizCanvas.gameObject.SetActive(false);
        Recticle.gameObject.SetActive(true);
    }

    public void ReturnGame() {
        quizCanvas.gameObject.SetActive(false);
        Recticle.gameObject.SetActive(true);
    }
}
