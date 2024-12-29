using UnityEngine;
using UnityEngine.UI;

public class MuteUnmuteController : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private Button muteButton;         // Reference to the mute button
    [SerializeField] private Button unmuteButton;       // Reference to the unmute button

    [Header("Audio Settings")]
    [SerializeField] private AudioSource backgroundMusic;  // Reference to the background music AudioSource

    private void Start()
    {
        // Set initial state based on whether the music is playing or not
        if (backgroundMusic != null && backgroundMusic.isPlaying)
        {
            muteButton.gameObject.SetActive(true); // Show mute button if music is playing
            unmuteButton.gameObject.SetActive(false); // Hide unmute button
        }
        else
        {
            muteButton.gameObject.SetActive(false); // Hide mute button if music is paused
            unmuteButton.gameObject.SetActive(true); // Show unmute button
        }

        // Add listeners to mute and unmute buttons
        muteButton.onClick.AddListener(MuteMusic);
        unmuteButton.onClick.AddListener(UnmuteMusic);
    }

    // Mute the music and show the unmute button
    private void MuteMusic()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Pause(); // Pause the music
            muteButton.gameObject.SetActive(false); // Hide mute button
            unmuteButton.gameObject.SetActive(true); // Show unmute button
            Debug.Log("Music muted.");
        }
    }

    // Unmute the music and show the mute button
    private void UnmuteMusic()
    {
        if (backgroundMusic != null)
        {
            backgroundMusic.Play(); // Play the music
            muteButton.gameObject.SetActive(true); // Show mute button
            unmuteButton.gameObject.SetActive(false); // Hide unmute button
            Debug.Log("Music unmuted.");
        }
    }
}
