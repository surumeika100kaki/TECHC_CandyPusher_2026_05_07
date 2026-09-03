using UnityEngine;

public class GetCoinRecoveryUpgrade : MonoBehaviour
{
    public int upgradeLevel = 0; // アップグレードのレベル
    public float upgradeCost = 10f; // アップグレードのコスト
    public GetCoinRecoveryUpgradeText getCoinRecoveryUpgradeText;
    public void UpgradeGetCoinIncrease()
    {
        upgradeLevel++;
        CoinRecoveryManeger.Instance.RecoveryCoinIncrease = Mathf.RoundToInt(1.5f * upgradeLevel);
        upgradeCost = Mathf.RoundToInt(upgradeCost * (1f + (upgradeLevel/100f)) + upgradeLevel); // 次のアップグレードコストを増加させる
        getCoinRecoveryUpgradeText.UpdateUpgradeText(); // テキストを更新する
    }
    public int GetUpgradeLevel()
    {
        return upgradeLevel;
    }

    public float GetUpgradeCost()
    {
        return upgradeCost;
    }
}
