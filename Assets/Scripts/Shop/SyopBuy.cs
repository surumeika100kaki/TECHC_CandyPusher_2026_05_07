using UnityEngine;

public class SyopBuy : MonoBehaviour
{
    public HighRollerUpgrade highRollerUpgrade;
    public CoinRecoveryCooldownUpgrade coinRecoveryCooldownUpgrade;
    public GetCoinRecoveryUpgrade getCoinRecoveryUpgrade;
    public void OnClickHighRollerBuy(){
        if (!CoinManager.Instance.UseCoin(highRollerUpgrade.GetUpgradeCost()))
        {
            return;
        }
        highRollerUpgrade.HighRollerBuyUpgrade();
    }
    public void OnClickCoinRecoveryCooldownBuy(){
        if (!CoinManager.Instance.UseCoin(Mathf.RoundToInt(coinRecoveryCooldownUpgrade.GetUpgradeCost())))
        {
            return;
        }
        coinRecoveryCooldownUpgrade.UpgradeCoinRecoveryCooldown();
    }
    public void OnClickGetCoinRecoveryBuy(){
        if (!CoinManager.Instance.UseCoin(Mathf.RoundToInt(getCoinRecoveryUpgrade.GetUpgradeCost())))
        {
            return;
        }
        getCoinRecoveryUpgrade.UpgradeGetCoinIncrease();
    }
}
