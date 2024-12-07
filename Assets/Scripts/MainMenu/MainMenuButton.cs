using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button mainMenuButton = GetComponent<Button>();
        mainMenuButton.onClick.AddListener(OpenMainMenu);
    }
    
    void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
