using UnityEngine;

public class AudioWalk : MonoBehaviour
{
    public AudioSource moveSound;
    
    void Start()
    {
        moveSound.volume = 4.5f;
    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.W)))
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }

        if ((Input.GetKey(KeyCode.A)))
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }

        if ((Input.GetKey(KeyCode.S)))
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else
        {
            moveSound.Stop();
        }

        if ((Input.GetKey(KeyCode.D)))
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