using System;
using UnityEngine;

public sealed class BattleProgression : MonoBehaviour
{
    [SerializeField, Min(1)] private int bossInterval = 5;
    [SerializeField, Min(1)] private int currentBattle = 1;

    public int CurrentBattle => currentBattle;
    public bool IsBossBattle => currentBattle % bossInterval == 0;

    public event Action<int, bool> BattleChanged;

    public void AdvanceToNextBattle()
    {
        currentBattle++;
        BattleChanged?.Invoke(currentBattle, IsBossBattle);
        Debug.Log($"Battle {currentBattle} started. Boss: {IsBossBattle}");
    }
}