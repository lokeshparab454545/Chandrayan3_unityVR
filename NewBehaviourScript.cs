using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Play the music
        audioSource.Play();
    }
}
