using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource music; // Ссылка на компонент AudioSource для проигрывания музыки
    public Button pauseButton; // Ссылка на кнопку "Пауза"
    public Button playButton; // Ссылка на кнопку "Воспроизвести"

    void Start()
    {
        // Назначаем обработчики событий для кнопок
        pauseButton.onClick.AddListener(PauseMusic);
        playButton.onClick.AddListener(PlayMusic);
    }

    // Метод для приостановки воспроизведения музыки
    void PauseMusic()
    {
        if (music.isPlaying)
        {
            music.Pause();
        }
    }

    // Метод для продолжения воспроизведения музыки
    void PlayMusic()
    {
        if (!music.isPlaying)
        {
            music.Play();
        }
    }
}
