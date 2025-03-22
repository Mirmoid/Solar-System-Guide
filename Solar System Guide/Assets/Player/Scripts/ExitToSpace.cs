using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitToSpace : MonoBehaviour
{
    public void Pause(int sceneIndex)
    {
            SceneManager.LoadScene(sceneIndex);
    }
}
