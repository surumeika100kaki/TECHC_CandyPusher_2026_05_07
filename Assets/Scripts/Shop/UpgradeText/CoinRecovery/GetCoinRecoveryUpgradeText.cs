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

        upgradeText.text = $"コイン回復量\n効果({CoinRecoveryManeger.Instance.RecoveryCoinIncrease})\n価格: {Mathf.RoundToInt(upgradeCost)} Level: {currentLevel}";
    }
}
