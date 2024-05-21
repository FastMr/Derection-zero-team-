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