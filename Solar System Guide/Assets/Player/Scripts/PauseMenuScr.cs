using UnityEngine;
using System.Collections;

public class PauseMenuScr : MonoBehaviour
{
    public GameObject menu;
    public GameObject dot;
    public GameObject camera;
    private bool isPaused = false;
    private bool isLocked;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }

        void PauseGame()
        {
            Time.timeScale = 0f;
            isPaused = true;
            AudioListener.pause = true;
            menu.SetActive(true);
            dot.SetActive(false);
            FirstPersonLook other = camera.GetComponent<FirstPersonLook>();
            other.enabled = false;

        }

        void ResumeGame()
        {
            Time.timeScale = 1f;
            isPaused = false;
            AudioListener.pause = false;
            menu.SetActive(false);
            dot.SetActive(true);
            FirstPersonLook other = camera.GetComponent<FirstPersonLook>();
            other.enabled = true;

        }
    }
}