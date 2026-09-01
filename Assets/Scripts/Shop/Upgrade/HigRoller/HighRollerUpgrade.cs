using UnityEngine;

public class HighRollerUpgrade : MonoBehaviour
{
    public HighRollerTextUpdate highRollerTextUpdate;

    private int UpgradeLevel = 0; // アップグレードのレベル
    private float UpgradeCost = 1f; // アップグレードのコスト

    public void HighRollerBuyUpgrade(){
        CoinManager.Instance.CoinIncrease += 1;
        CoinManager.Instance.CoinCost += 1;
        UpgradeLevel++;
        highRollerTextUpdate.highRollerTextUpdate();
    }
    public int GetUpgradeCost()
    {
        return Mathf.RoundToInt(UpgradeCost * UpgradeLevel * 1.5f);
    }
    public int GetUpgradeLevel()
    {
        return UpgradeLevel;
    }
}
