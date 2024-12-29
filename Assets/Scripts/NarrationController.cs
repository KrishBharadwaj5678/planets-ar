using UnityEngine;
using UnityEngine.UI;

public class NarrationController : MonoBehaviour
{
    [Header("Audio Controls")]
    [SerializeField] private Button playButton;    // Reference to the Play button
    [SerializeField] private Button pauseButton;   // Reference to the Pause button
    [SerializeField] private Button resetButton;   // Reference to the Reset button

    [Header("Audio Settings")]
    [SerializeField] private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Ensure the audio is not playing initially
        audioSource.Pause();

        // Add listeners to buttons
        playButton.onClick.AddListener(PlayAudio);
        pauseButton.onClick.AddListener(PauseAudio);
        resetButton.onClick.AddListener(ResetAudio);
    }

    // Play the audio if it's not playing
    private void PlayAudio()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Pause the audio if it's playing
    private void PauseAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }

    // Reset the audio to the beginning and stop it
    private void ResetAudio()
    {
        audioSource.Stop();
        audioSource.Play(); // Restart from the beginning
    }
}
