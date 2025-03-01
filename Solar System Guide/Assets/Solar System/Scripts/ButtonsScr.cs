using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;
    public GameObject HideButton1;
    public GameObject HideButton2;
    public GameObject HideButton3;
    public GameObject HideButton4;
    public void ChangePlane(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
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
        HideButton1.SetActive(true);
    }
    public void Settings()
    {
        Background.SetActive(false);
        Background2.SetActive(true);
        HideButton1.SetActive(false);
        HideButton2.SetActive(false);
        HideButton3.SetActive(false);
    }
    public void VisuaslHide()
    {
        Background.SetActive(true);
        HideButton1.SetActive(false);
    }
    public void Hide2()
    {
        Background2.SetActive(false);
        HideButton4.SetActive(false);
        HideButton3.SetActive(true);
    }
    public void VisuaslHide2()
    {
        Background2.SetActive(true);
        HideButton3.SetActive(false);
        HideButton4.SetActive(true);
    }
}