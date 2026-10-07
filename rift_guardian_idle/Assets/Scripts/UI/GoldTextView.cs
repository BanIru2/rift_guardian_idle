using UnityEngine;

[RequireComponent(typeof(TMPro.TMP_Text))]
public sealed class GoldTextView : MonoBehaviour
{
    [SerializeField]
    private PlayerWallet wallet;

    private TMPro.TMP_Text goldText;

    private void Awake()
    {
        goldText = GetComponent<TMPro.TMP_Text>();
    }

    private void OnEnable()
    {
        if (wallet == null)
        {
            return;
        }

        wallet.GoldChanged += Refresh;
        Refresh(wallet.CurrentGold);
    }

    private void OnDisable()
    {
        if (wallet != null)
        {
            wallet.GoldChanged -= Refresh;
        }
    }

    private void Refresh(int gold)
    {
        goldText.text = $"Gold: {gold}";
    }
}