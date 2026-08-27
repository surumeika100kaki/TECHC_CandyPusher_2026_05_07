using UnityEngine;

public class HighRollerUpgrade : MonoBehaviour
{
    public void HighRollerBuyUpgrade(){
        CoinManager.Instance.CoinIncrease += 1;
        CoinManager.Instance.CoinCost += 1;
    }
}
