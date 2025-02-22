using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;
    public GameObject HideButton;
    public GameObject HideButton2;
    public void Exit()
    {

#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#endif
        Application.Quit();
    }
    public void Hide()
    {
        Background.SetActive(false);
        Background2.SetActive(false);
        HideButton.SetActive(true);
    }
    public void ChangePlane(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void Settings()
    {
        Background.SetActive(false);
        Background2.SetActive(true);
    }
    public void removeSet()
    {
        Background.SetActive(true);
        HideButton.SetActive(false);
    }
}
