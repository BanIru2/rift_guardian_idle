using UnityEngine;

[RequireComponent(typeof(Animator))]
public sealed class PlayerHealth : MonoBehaviour
{
    private static readonly int HitHash = Animator.StringToHash("Hit");
    private static readonly int DieHash = Animator.StringToHash("Die");
    private static readonly int IdleHash = Animator.StringToHash("HeroKnight_Idle");

    [SerializeField, Min(1)]
    private int maxHealth = 100;

    [SerializeField]
    private int currentHealth;

    private Animator animator;
    private bool isDead;

    public int CurrentHealth => currentHealth;
    public int MaxHealth => maxHealth;
    public bool IsDead => isDead;

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
            return;
        }

        animator.SetTrigger(HitHash);
    }

    public void RestoreFullHealth()
    {
        currentHealth = maxHealth;

        if (!isDead)
        {
            return;
        }

        isDead = false;

        animator.ResetTrigger(HitHash);
        animator.ResetTrigger(DieHash);
        animator.Play(IdleHash, 0, 0f);
        animator.Update(0f);
    }

    [ContextMenu("Take 25 Test Damage")]
    private void TakeTestDamage()
    {
        TakeDamage(25);
    }
}