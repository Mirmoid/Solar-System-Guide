using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangePlane(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}