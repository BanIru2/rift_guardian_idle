using UnityEngine;

public sealed class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth target;

    [SerializeField, Min(1)]
    private int attackDamage = 10;

    public void OnAttackHit()
    {
        if (target == null)
        {
            return;
        }

        target.TakeDamage(attackDamage);
    }
}