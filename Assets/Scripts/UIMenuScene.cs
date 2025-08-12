using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIMenuScene : MonoBehaviour

{
    public TMP_InputField nameField;
    public TMP_Text bestScoreText;


    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        bestScoreText.text = "Best Score: " + Manager.Instance.bestScoreName + ": " + Manager.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Manager.Instance.playerName = nameField.text;
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
