using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips;
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayCurrentClip();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }

    private void PlayCurrentClip()
    {
        if (currentClipIndex < musicClips.Length)
        {
            audioSource.clip = musicClips[currentClipIndex];
            audioSource.Play();
        }
    }

    private void PlayNextClip()
    {
        currentClipIndex++;
        if (currentClipIndex >= musicClips.Length)
        {
            currentClipIndex = 0;
        }

        PlayCurrentClip();
    }
}