using UnityEngine;

public sealed class AttackUpgradeController : MonoBehaviour
{
    [SerializeField]
    private PlayerWallet wallet;

    [SerializeField]
    private PlayerCombatStats combatStats;

    [SerializeField, Min(1)]
    private int upgradeCost = 10;

    [SerializeField, Min(1)]
    private int attackIncrease = 5;

    public bool TryUpgradeAttack()
    {
        if (wallet == null || combatStats == null)
        {
            return false;
        }

        if (!wallet.TrySpendGold(upgradeCost))
        {
            return false;
        }

        combatStats.UpgradeAttack(attackIncrease);
        return true;
    }

    public void UpgradeAttack()
    {
        bool succeeded = TryUpgradeAttack();

        Debug.Log(
            $"Upgrade succeeded: {succeeded}, " +
            $"Level: {combatStats.AttackUpgradeLevel}, " +
            $"Damage: {combatStats.AttackDamage}");
    }

    [ContextMenu("Upgrade Attack")]
    private void UpgradeAttackTest()
    {
        UpgradeAttack();
    }
}