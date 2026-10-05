using UnityEngine;

[RequireComponent(typeof(Animator), typeof(EnemyHealth))]
public sealed class EnemyAutoAttack : MonoBehaviour
{
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField]
    private PlayerHealth target;

    [SerializeField, Min(0.1f)]
    private float attackInterval = 2f;

    private Animator animator;
    private EnemyHealth enemyHealth;
    private float attackTimer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    private void Update()
    {
        if (enemyHealth.IsDead || target == null || target.IsDead)
        {
            return;
        }

        attackTimer += Time.deltaTime;

        if (attackTimer < attackInterval)
        {
            return;
        }

        attackTimer = 0f;
        animator.SetTrigger(AttackHash);
    }
}