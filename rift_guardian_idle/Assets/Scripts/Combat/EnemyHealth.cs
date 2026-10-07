using UnityEngine;
using System;

[RequireComponent(typeof(Animator))]
public sealed class EnemyHealth : MonoBehaviour
{
    private static readonly int HitHash = Animator.StringToHash("Hit");
    private static readonly int DieHash = Animator.StringToHash("Die");
    private static readonly int IdleHash = Animator.StringToHash("Goblin_Idle");

    [SerializeField, Min(1)]
    private int maxHealth = 30;
    [SerializeField]
    private int currentHealth;

    [SerializeField]
    private bool isBoss;

    private Animator animator;
    private bool isDead;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public bool IsBoss => isBoss;
    public bool IsDead => isDead;
    public event Action Died;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead || damage <= 0)
        {
            return;
        }

        currentHealth = Mathf.Max(0, currentHealth - damage);

        if (currentHealth == 0)
        {
            isDead = true;
            animator.SetTrigger(DieHash);
            Died?.Invoke();
            return;
        }

        animator.SetTrigger(HitHash);
    }

    public void Revive()
    {
        currentHealth = maxHealth;
        isDead = false;

        animator.ResetTrigger(HitHash);
        animator.ResetTrigger(DieHash);
        animator.Play(IdleHash, 0, 0f);
        animator.Update(0f);
    }

    public void PrepareForBattle(int health, bool boss)
    {
        maxHealth = Mathf.Max(1, health);
        isBoss = boss;

        Revive();
    }

    [ContextMenu("Take 10 Test Damage")]
    private void TakeTestDamage()
    {
        TakeDamage(10);
    }

    [ContextMenu("Revive")]
    private void ReviveTest()
    {
        Revive();
    }
}