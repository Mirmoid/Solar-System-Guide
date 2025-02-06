using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangePlanet(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}