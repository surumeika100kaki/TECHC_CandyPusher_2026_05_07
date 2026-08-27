using UnityEngine;
using TMPro;

public class HighRollerTextUpdate : MonoBehaviour
{
    public TextMeshProUGUI HighRollerText;
    public void highRollerTextUpdate(){
        HighRollerText.text =
        $"ハイローラー\n効果(消費:{CoinManager.Instance.CoinCost}増加:{CoinManager.Instance.CoinIncrease})\n価格:{Mathf.RoundToInt(CoinManager.Instance.CoinCost * 1.5f)}";
    }
    private void Start() {
        highRollerTextUpdate();
    }
}
