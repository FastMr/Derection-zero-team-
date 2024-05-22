using UnityEngine;

public class AudioWalk : MonoBehaviour
{
    public AudioSource moveSound;
    public float volume = 0.4f;


    void Start()
    {
        moveSound.volume = volume;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }
    }
}