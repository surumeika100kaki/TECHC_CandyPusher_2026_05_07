using UnityEngine;
using TMPro;

public class CoinRecoveryCooldownUpgradTextUpdate : MonoBehaviour
{
    public CoinRecoveryCooldownUpgrade coinRecoveryCooldownUpgrade;
    public TextMeshProUGUI upgradeText;

    public void Start()
    {
        CoinRecoveryCooldownUpgradeTextUpdate();
    }

    public void CoinRecoveryCooldownUpgradeTextUpdate()
    {
        if (upgradeText == null || coinRecoveryCooldownUpgrade == null || CoinRecoveryManeger.Instance == null)
            return;

        int currentLevel = coinRecoveryCooldownUpgrade.GetUpgradeLevel();
        
        // コイン獲得にかかる合計秒数 (N秒)
        float totalTime = CoinRecoveryManeger.Instance.GetRecoveryTime() * 100f;
        int currentSeconds = Mathf.FloorToInt(totalTime);

        // 強化で減る秒数（0.01秒 × 100 = 1秒）
        int reduceSeconds = 1;

        // 強化コスト（小数点以下切り捨て）
        int cost = Mathf.FloorToInt(coinRecoveryCooldownUpgrade.GetUpgradeCost());

        // 最大レベル判定（Level 9 または 1秒に達した場合）
        if (currentLevel >= 9 || currentSeconds <= 1)
        {
            upgradeText.text = $"リカバリークールダウン\n効果({currentSeconds}-{reduceSeconds}秒\n価格: ----- Level: {currentLevel}";
        }
        else
        {
            upgradeText.text = $"リカバリークールダウン\n効果({currentSeconds}-{reduceSeconds}秒)\n価格: {cost} Level: {currentLevel}" ;
        }
    }
}