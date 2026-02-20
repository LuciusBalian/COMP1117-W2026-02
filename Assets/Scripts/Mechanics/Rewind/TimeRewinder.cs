using UnityEngine;
using UnityEngine.InputSystem;

public class TimeRewinder : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private int maxFrames = 300;
    public bool isRewinding = false;

    private CircularBuffer intBuffer;
    private void Awake()
    {
        intBuffer = new CircularBuffer(maxFrames);

    }

    public void onRewind(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isRewinding = true;
            Debug.Log("Rewind Started");
        }
        else if (context.canceled)
        {
            isRewinding = false;
            Debug.Log("Rewind Cancelled");
        }
    }

    private void Update()
    {
        if (!isRewinding)
            Record();
        else
            Rewind();
    }

    //Record - records information every frame

    private void Record()
    {
        int tempInt = Random.Range(0, 1000);
        intBuffer.Push(tempInt);
    }

    //Rewind - retrieves information every frame from the buffer

    private void Rewind()
    {
        int tempInt = intBuffer.Pop();
        Debug.Log("Popped Value: " + tempInt);
    }
}
