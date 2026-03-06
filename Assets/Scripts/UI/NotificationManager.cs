using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class NotificationManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    private TextMeshProUGUI dataText;
    public void PostNotification<T>(T data)
    {
        
        dataText = canvas.GetComponent<TextMeshProUGUI>();
        dataText.text = data.ToString();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string text = "yoyyoyo";
        PostNotification<string>(text);

    }
}
