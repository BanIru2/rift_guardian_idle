using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Button))]
public sealed class AttackUpgradeButton : MonoBehaviour
{
    [SerializeField]
    private AttackUpgradeController upgradeController;

    private UnityEngine.UI.Button button;

    private void Awake()
    {
        button = GetComponent<UnityEngine.UI.Button>();
    }

    private void OnEnable()
    {
        button.onClick.AddListener(HandleClick);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(HandleClick);
    }

    private void HandleClick()
    {
        if (upgradeController == null)
        {
            return;
        }

        upgradeController.UpgradeAttack();
    }
}