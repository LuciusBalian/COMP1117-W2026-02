using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Initial Player Stats
    [Header("Initial Player Stats")]
    [SerializeField] private float initialSpeed = 5.0f;
    [SerializeField] private int initialHealth = 100;

    // Private Variables
    private PlayerStats stats;
    private Vector2 moveInput;

    // Components
    private Rigidbody2D rBody;

    void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();

        stats = new PlayerStats(initialSpeed, initialHealth);
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
    }

    private void ApplyMovement()
    {
        float targetVelocityX = moveInput.x * stats.MoveSpeed;

        rBody.linearVelocity = new Vector2(targetVelocityX, rBody.linearVelocity.y);
    }

    public void TakeDamage(int damageAmount)
    {
        stats.CurrentHealth -= damageAmount;

        Debug.Log("Player took damage");
    }
}
