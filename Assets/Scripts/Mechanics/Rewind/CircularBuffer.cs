using System.Collections.Generic;

public class CircularBuffer
{
    private List<int> buffer;
    private int capacity;

    public CircularBuffer(int capacity)
    {
        buffer = new List<int>(capacity);
        this.capacity = capacity;
    }

    //public int Count
    //{
    //    get
    //    {
    //        return buffer.Count;
    //    }
    //}

    public int Count => buffer.Count;
    public void Push(int item)
    {
        // check if buffer is at or above capacity
        if (buffer.Count >= capacity)
        {
            buffer.RemoveAt(0);
        }
        buffer.Add(item);
    }

    public int Pop()
    {
        if (buffer.Count == 0)
        {
            return -1; // -1 will act as a special value to check against
        }
        int lastIndex = buffer.Count - 1;

        int item = buffer[lastIndex];
        buffer.RemoveAt(lastIndex);

        return item;
    }
}
