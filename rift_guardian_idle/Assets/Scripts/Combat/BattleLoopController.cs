using System.Collections;
using UnityEngine;

public sealed class BattleLoopController : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth enemy;
    [SerializeField]
    private PlayerHealth player;
    [SerializeField]
    private BattleProgression progression;

    [SerializeField, Min(1)]
    private int normalEnemyHealth = 30;
    [SerializeField, Min(1)]
    private int bossEnemyHealth = 50;
    [SerializeField, Min(1f)]
    private float bossScaleMultiplier = 1.4f;
    [SerializeField, Min(0f)]
    private float reviveDelay = 2f;

    private Vector3 normalEnemyScale;

    private Coroutine reviveRoutine;

    private void Awake()
    {
        if (enemy != null)
        {
            normalEnemyScale = enemy.transform.localScale;
        }
    }

    private void OnEnable()
    {
        if (enemy != null)
        {
            enemy.Died += HandleEnemyDied;
        }
    }

    private void OnDisable()
    {
        if (enemy != null)
        {
            enemy.Died -= HandleEnemyDied;
        }
    }

    private void HandleEnemyDied()
    {
        if (reviveRoutine != null)
        {
            StopCoroutine(reviveRoutine);
        }

        reviveRoutine = StartCoroutine(ReviveAfterDelay());
    }

    private IEnumerator ReviveAfterDelay()
    {
        yield return new WaitForSeconds(reviveDelay);

        if (player != null)
        {
            player.RestoreFullHealth();
        }

        if (progression != null)
        {
            progression.AdvanceToNextBattle();
        }

        bool isBossBattle = progression != null && progression.IsBossBattle;
        int enemyHealth = isBossBattle ? bossEnemyHealth : normalEnemyHealth;

        enemy.transform.localScale = isBossBattle ? normalEnemyScale * bossScaleMultiplier : normalEnemyScale;
        enemy.PrepareForBattle(enemyHealth, isBossBattle);

        reviveRoutine = null;
    }
}