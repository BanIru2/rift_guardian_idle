using UnityEngine;

public sealed class GoblinAnimationEvents : MonoBehaviour
{
    [SerializeField]
    private PlayerHealth target;

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