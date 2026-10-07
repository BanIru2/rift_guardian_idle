using UnityEngine;

[RequireComponent(typeof(PlayerCombatStats))]
public sealed class PlayerAnimationEvents : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth target;

    private PlayerCombatStats combatStats;

    private void Awake()
    {
        combatStats = GetComponent<PlayerCombatStats>();
    }

    public void OnAttackHit()
    {
        if (target == null)
        {
            return;
        }

        target.TakeDamage(combatStats.AttackDamage);
    }
}