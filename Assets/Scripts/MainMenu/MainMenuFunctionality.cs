using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunctionality : MonoBehaviour
{
    [SerializeField]
    public Button _playGameButton;
    [SerializeField]
    public Button _levelMenuButton;
    [SerializeField]
    public Button _instructionsButton;
    [SerializeField]
    public Button _creditsButton;

    private void Start()
    {
        _playGameButton.onClick.AddListener(StartGame);
        _levelMenuButton.onClick.AddListener(OpenLevels);
        _instructionsButton.onClick.AddListener(OpenInstructions);
        _creditsButton.onClick.AddListener(OpenCredits);
    }

    void StartGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }

    void OpenLevels()
    {
        SceneManager.LoadScene("LevelMapScene");
    }

    void OpenInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    void OpenCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
