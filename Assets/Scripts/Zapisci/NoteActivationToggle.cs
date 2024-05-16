using UnityEngine;
using System;

public class NoteActivationToggle : MonoBehaviour
{
    public GameObject Note;
    private bool _isTimeStopped = false;

    private void Update()
    {
        // Проверка нажатия кнопки E
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Проверка коллизии с игроком
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 1f))
            {
                if (hit.collider.gameObject.tag == "Player")
                {
                    // Переключение активности объекта Note
                    Note.SetActive(!Note.activeSelf);

                    // Остановка или возобновление времени
                    _isTimeStopped = !_isTimeStopped;
                    Time.timeScale = _isTimeStopped ? 0f : 1f;
                }
            }
        }
    }
}