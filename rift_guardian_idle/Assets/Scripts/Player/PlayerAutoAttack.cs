using UnityEngine;

[RequireComponent(typeof(Animator))]
public sealed class PlayerAutoAttack : MonoBehaviour
{
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField]
    private EnemyHealth target;

    [SerializeField, Min(0.1f)]
    private float attackInterval = 1.5f;

    private Animator animator;
    private float attackTimer;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (target == null || target.IsDead)
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