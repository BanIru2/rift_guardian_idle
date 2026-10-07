using System;
using UnityEngine;

public sealed class PlayerCombatStats : MonoBehaviour
{
    [SerializeField, Min(1)]
    private int attackDamage = 10;

    [SerializeField, Min(0)]
    private int attackUpgradeLevel;

    public int AttackDamage => attackDamage;
    public int AttackUpgradeLevel => attackUpgradeLevel;

    public event Action StatsChanged;

    public void UpgradeAttack(int increaseAmount)
    {
        if (increaseAmount <= 0)
        {
            return;
        }

        attackDamage += increaseAmount;
        attackUpgradeLevel++;

        StatsChanged?.Invoke();
    }

    [ContextMenu("Upgrade Attack Test")]
    private void UpgradeAttackTest()
    {
        UpgradeAttack(5);
        Debug.Log(
            $"Attack Level: {attackUpgradeLevel}, Damage: {attackDamage}");
    }
}