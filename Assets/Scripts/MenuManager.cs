using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject PausePanel;
    public void PauseLevelButton() { Time.timeScale = 0f; PausePanel.SetActive(true); }
    public void StartLevelButton() { Time.timeScale = 1f; PausePanel.SetActive(false); }
    public void MenuButton() { SceneManager.LoadScene(0); Time.timeScale = 1f; }
    public void StartGameButton() { SceneManager.LoadScene(1); Time.timeScale = 1f; }
    public void Exit() { Application.Quit(); }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausePanel.activeSelf) StartLevelButton();
            else if (!PausePanel.activeSelf) PauseLevelButton();
        }
    }
}
