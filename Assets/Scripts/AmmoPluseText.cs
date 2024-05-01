using UnityEngine;
using UnityEngine.UI;

public class AmmoPluseText : MonoBehaviour
{
    public Text ammoPluseText; // Текстовый компонент для отображения количества патронов

    public int AmmoPluse
    {
        get { return int.Parse(ammoPluseText.text); }
        set { ammoPluseText.text = value.ToString(); }
    }

    private void Update()
    {
        // Обновить текст, чтобы отобразить текущее количество патронов
        ammoPluseText.text = AmmoPluse.ToString();
    }
}
