using UnityEngine;

public class HideBackButton : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;
    public void Hide()
    {
        Background.SetActive(false);
        Background2.SetActive(false);
    }
}
