using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public AudioSource music;
    public Button pauseButton;
    public Button playButton;

    void Start()
    {

        pauseButton.onClick.AddListener(PauseMusic);
        playButton.onClick.AddListener(PlayMusic);
    }


    void PauseMusic()
    {
        if (music.isPlaying)
        {
            music.Pause();
        }
    }


    void PlayMusic()
    {
        if (!music.isPlaying)
        {
            music.Play();
        }
    }
}
