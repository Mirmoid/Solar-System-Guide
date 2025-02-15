using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SettingsButton : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;
    public void Settings()
    {
        Background.SetActive(false);
        Background2.SetActive(true);
    }
}
