using UnityEngine;
using UnityEngine.InputSystem;

public class TestEnemy : MonoBehaviour
{
    // public const string PLAYER_TAG = "Player";

    [SerializeField] private PlayerController thePlayerController;

    /*
    private void Awake()
    {
        // Option 1 - Not recommended
        
        GameObject thePlayer = GameObject.FindGameObjectWithTag(PLAYER_TAG);

        thePlayer.GetComponent<PlayerController>().TakeDamage(20);
        

        // Option 2 - Better, but not the best
       
        PlayerController thePlayerController = GameObject.FindFirstObjectByType<PlayerController>();

        thePlayerController.TakeDamage(10);
        

    }
    */

    public void OnAttack(InputValue value)
    {
        if(value.isPressed)
        {
            thePlayerController.TakeDamage(10);
        }
    }
}
