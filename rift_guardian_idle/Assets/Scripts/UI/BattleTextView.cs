using UnityEngine;

[RequireComponent(typeof(TMPro.TMP_Text))]
public sealed class BattleTextView : MonoBehaviour
{
    [SerializeField] private BattleProgression progression;

    private TMPro.TMP_Text battleText;

    private void Awake()
    {
        battleText = GetComponent<TMPro.TMP_Text>();
    }

    private void OnEnable()
    {
        if (progression == null)
        {
            return;
        }

        progression.BattleChanged += Refresh;
        Refresh(progression.CurrentBattle, progression.IsBossBattle);
    }

    private void OnDisable()
    {
        if (progression != null)
        {
            progression.BattleChanged -= Refresh;
        }
    }

    private void Refresh(int battle, bool isBoss)
    {
        battleText.text = isBoss ? $"BATTLE {battle}\nBOSS" : $"BATTLE {battle}";
    }
}