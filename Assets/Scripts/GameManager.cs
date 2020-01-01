using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if ( !gameHasEnded )
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            // Restart the game.
            //RestartGame();
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        Debug.Log("Level WON");
        completeLevelUI.SetActive(true);
    }
}
