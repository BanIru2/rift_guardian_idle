using UnityEngine;

public sealed class PlayerAnimationEvents : MonoBehaviour
{
    public void OnAttackHit()
    {
        Debug.Log("Attack hit frame", this);
    }
}