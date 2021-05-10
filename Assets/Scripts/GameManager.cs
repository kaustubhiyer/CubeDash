using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public float restartDelay = 2f;
    public void EndGame() {
        if (gameHasEnded == false) {
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
            Restart();
        }
        gameHasEnded = true;
    }

    public void CompleteLevel () {
        completeLevelUI.SetActive(true);
        Debug.Log("Level 1 Complete");
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
