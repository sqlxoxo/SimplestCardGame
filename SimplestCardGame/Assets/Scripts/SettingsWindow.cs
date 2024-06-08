using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public GameObject settingsWindow;

    void Start()
    {
        // Скрыть окно настроек при запуске
        settingsWindow.SetActive(false);
    }

    public void OpenSettings()
    {
        // Открыть окно настроек
        settingsWindow.SetActive(true);
    }

    public void CloseSettings()
    {
        // Закрыть окно настроек
        settingsWindow.SetActive(false);
    }
}
