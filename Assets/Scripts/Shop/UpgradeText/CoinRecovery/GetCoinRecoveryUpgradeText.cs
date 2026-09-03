using UnityEngine;
using TMPro;

public class GetCoinRecoveryUpgradeText : MonoBehaviour
{
    public TextMeshProUGUI upgradeText;
    public GetCoinRecoveryUpgrade getCoinRecoveryUpgrade;
    public  void Start()
    {
        UpdateUpgradeText();
    }
    public void UpdateUpgradeText()
    {
        if (upgradeText == null)
            return;
        if (getCoinRecoveryUpgrade == null)
            return;
        int currentLevel = getCoinRecoveryUpgrade.GetUpgradeLevel();
        float upgradeCost = getCoinRecoveryUpgrade.GetUpgradeCost();

        upgradeText.text = $"コイン回復量アップ\n回復量: {CoinRecoveryManeger.Instance.RecoveryCoinIncrease}\n Level: {currentLevel} 価格: {Mathf.RoundToInt(upgradeCost)}";
    }
}
