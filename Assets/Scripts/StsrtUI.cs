using UnityEngine;
using UnityEngine.SceneManagement;

public class StsrtUI : MonoBehaviour
{
    public void StartGameMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
