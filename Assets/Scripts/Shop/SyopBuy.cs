using UnityEngine;

public class SyopBuy : MonoBehaviour
{
    public HighRollerUpgrade highRollerUpgrade;
    public HighRollerTextUpdate highRollerTextUpdate;
    public CoinRecovery CoinRecovery;
    public void OnClicHighRollerBuy(){
        if (!CoinManager.Instance.UseCoin(Mathf.RoundToInt(CoinManager.Instance.CoinCost * 1.5f)))
        {
            return;
        }
        highRollerUpgrade.HighRollerBuyUpgrade();
        highRollerTextUpdate.highRollerTextUpdate();
    }
    public void OnClicCoinRecoveryBuy(){
        if (!CoinManager.Instance.UseCoin(Mathf.RoundToInt(CoinRecovery.RecoveryCoinIncrease * 1.1f)))
        {
            return;
        }
    }
}
