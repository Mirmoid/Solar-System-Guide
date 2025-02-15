using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void Exit()
    {

#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#endif
        Application.Quit();
    }
}
