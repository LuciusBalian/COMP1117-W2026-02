using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerStats stats;

    // Components
    Rigidbody2D rBody;

    // Private variables
    Vector2 moveInput;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();


        

   
        
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
        stats = new PlayerStats();
        stats.MoveSpeed = 100;
        Debug.Log(stats.MoveSpeed);
    }

    private void ApplyMovement()
    {
        float targetVelocityX = moveInput.x;

        rBody.linearVelocity = new Vector2(targetVelocityX, rBody.linearVelocity.y);
    }
}
