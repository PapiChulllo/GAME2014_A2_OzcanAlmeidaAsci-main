using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenuFunctionality : MonoBehaviour
{
    [SerializeField]
    public Button _level1Button;
    [SerializeField]
    public Button _level2Button;

    // Start is called before the first frame update
    void Start()
    {
        _level1Button.onClick.AddListener(() => StartGame(GameState.LEVEL1));
        _level2Button.onClick.AddListener(() => StartGame(GameState.LEVEL2));
    }

    private void StartGame(GameState state)
    {
        GameManager.Instance.ChooseLevel(state);
        SceneManager.LoadScene("GameplayScene");
    }
    
}
