using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    private string bestPlayer;
    private int bestScore;
    public TextMeshProUGUI scoreText;
    public GameObject nameText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadScore();
        bestPlayer = GameManager.Instance.bestPlayer;
        bestScore = GameManager.Instance.bestScore;
        scoreText.text = "Best Score: " + bestPlayer + ": " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        GameManager.Instance.currentPlayer = nameText.GetComponent<Text>().text;
    }
    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
