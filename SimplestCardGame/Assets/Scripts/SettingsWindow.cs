using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public GameObject settingsWindow;

    void Start()
    {

        settingsWindow.SetActive(false);
    }

    public void OpenSettings()
    {

        settingsWindow.SetActive(true);
    }

    public void CloseSettings()
    {

        settingsWindow.SetActive(false);
    }
}
