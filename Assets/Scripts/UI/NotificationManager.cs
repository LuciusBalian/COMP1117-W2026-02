using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class NotificationManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private TextMeshProUGUI dataText;
    public void PostNotification<T>(T data)
    {
        
        
        textMeshPro.text = data.ToString();

    }
    
}
