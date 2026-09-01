using UnityEngine;
using TMPro;

public class HighRollerTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI HighRollerText;
    public HighRollerUpgrade highRollerUpgrade;
    public void highRollerTextUpdate(){
        HighRollerText.text =
        $"獲得量アップ\n獲得量:{CoinManager.Instance.CoinIncrease}消費量:{CoinManager.Instance.CoinCost}\nLevel: {highRollerUpgrade.GetUpgradeLevel()} 価格:{highRollerUpgrade.GetUpgradeCost()}";
    }
    private void Start() {
        highRollerTextUpdate();
    }
}
