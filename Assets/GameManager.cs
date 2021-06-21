using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public void endGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("restart", 1f);
        }
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void endLevel()
    {
        Debug.Log("Level Completed!");

    }
    public GameObject levelCompletionUI;
    public void completeLevel()
    {
        Debug.Log("Level Complete");
        levelCompletionUI.SetActive(true);
    }
}
