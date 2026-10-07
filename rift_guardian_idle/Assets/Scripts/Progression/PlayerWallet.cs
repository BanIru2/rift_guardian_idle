using UnityEngine;
using System;

public sealed class PlayerWallet : MonoBehaviour
{
    [SerializeField, Min(0)]
    private int currentGold;
    public int CurrentGold => currentGold;

    public event Action<int> GoldChanged;

    public void AddGold(int amount)
    {
        if (amount <= 0)
        {
            return;
        }

        currentGold += amount;
        GoldChanged?.Invoke(currentGold);

        Debug.Log($"Gold: {currentGold}");
    }

    public bool TrySpendGold(int amount)
    {
        if (amount <= 0 || currentGold < amount)
        {
            return false;
        }

        currentGold -= amount;
        GoldChanged?.Invoke(currentGold);

        return true;
    }


    // =================================== Å×½ºÆ® ======================================
    [ContextMenu("Add 10 Test Gold")]
    private void AddTestGold()
    {
        AddGold(10);
    }

    [ContextMenu("Spend 5 Test Gold")]
    private void SpendTestGold()
    {
        bool succeeded = TrySpendGold(5);
        Debug.Log($"Spend succeeded: {succeeded}, Gold: {currentGold}");
    }
}