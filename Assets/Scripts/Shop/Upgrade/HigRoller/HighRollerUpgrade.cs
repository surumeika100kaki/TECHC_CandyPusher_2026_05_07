using UnityEngine;

public class HighRollerUpgrade : MonoBehaviour
{
    public HighRollerTextUpdate highRollerTextUpdate;

    private int UpgradeLevel = 0; // アップグレードのレベル

    public void HighRollerBuyUpgrade(){
        CoinManager.Instance.CoinIncrease += 1;
        CoinManager.Instance.CoinCost += 1;
        UpgradeLevel++;
        highRollerTextUpdate.highRollerTextUpdate();
    }
    public int GetUpgradeCost()
    {
        return Mathf.RoundToInt(UpgradeLevel * 1.5f);
    }
    public int GetUpgradeLevel()
    {
        return UpgradeLevel;
    }
}
