using UnityEngine;

public sealed class BattleRewardController : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth target;

    [SerializeField]
    private PlayerWallet wallet;

    [SerializeField, Min(1)]
    private int normalGoldReward = 10;
    [SerializeField, Min(1)]
    private int bossGoldReward = 50;

    private void OnEnable()
    {
        if (target != null)
        {
            target.Died += GrantReward;
        }
    }

    private void OnDisable()
    {
        if (target != null)
        {
            target.Died -= GrantReward;
        }
    }

    private void GrantReward()
    {
        if (target == null || wallet == null)
        {
            return;
        }

        int reward = target.IsBoss ? bossGoldReward : normalGoldReward;

        wallet.AddGold(reward);

        Debug.Log($"Reward: {reward}, Boss: {target.IsBoss}");
    }
}