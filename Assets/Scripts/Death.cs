using System;
using System.Collections;
using UnityEngine;

public class Death : MonoBehaviour
{
    private AudioController audio;
    private UserInterface userInterface;
    private bool gameOver = false;

    private void Awake()
    {
        userInterface = GetComponent<UserInterface>();
    }

    public bool GameOver
    {
        get => gameOver;
    }
    
    public void ExecuteSnake()
    {
        gameOver = true;
        GetComponent<AudioController>().Play(0);
        userInterface.GameOver();
        StartCoroutine(ReloadScene());
    }

    private IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(5f);
        userInterface.RestartButton();
    }
    
}
