using UnityEngine;

public class sendData : MonoBehaviour
{
    NotificationManager notificationManager;

    void Awake()
    {
        notificationManager = GetComponent<NotificationManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        string text = "yoyyoyo";
        notificationManager.PostNotification<string>(text);
    }
}
