using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _Levels = new List<GameObject>();
    private void Awake()
    {
        if(GameManager.Instance._currentState == GameState.LEVEL1)
        {
            foreach(GameObject level in _Levels)
            {
                if(level.name == "LEVEL1")
                {
                    level.SetActive(true);
                }
            }
        }
        else if(GameManager.Instance._currentState == GameState.LEVEL2)
        {
            foreach (GameObject level in _Levels)
            {
                if (level.name == "LEVEL2")
                {
                    level.SetActive(true);
                }
            }
        }
    }
}
