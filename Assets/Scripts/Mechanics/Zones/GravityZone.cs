using UnityEngine;

public class GravityZone : Zone
{
    protected override void ApplyZoneEffect(Player player)
    {

        player.ApplyGravityModifier(-1.0f);
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyGravityModifier(5.0f);
        }
    }


}
