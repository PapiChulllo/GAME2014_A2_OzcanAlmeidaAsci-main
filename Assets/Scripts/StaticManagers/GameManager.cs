using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameState _currentState;
    // Start is called before the first frame update
    void Start()
    {
        SayHello();
        _currentState = GameState.LEVEL1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseLevel(GameState state)
    {
        _currentState = state;
    }
}

public enum GameState
{
    LEVEL1,
    LEVEL2,
    LEVEL3,
}
