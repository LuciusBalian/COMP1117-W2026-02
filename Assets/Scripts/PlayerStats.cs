using UnityEngine;

public class PlayerStats
{
    private float moveSpeed = 100.0f;
    public float MoveSpeed
    {
        get
        {
            return moveSpeed;
        }
        set
        {
            if (moveSpeed > 20)
            {
                moveSpeed = 20;
            }
            else
            {
                moveSpeed = value;
            } 
        }
    }
}
