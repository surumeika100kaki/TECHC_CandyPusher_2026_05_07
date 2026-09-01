using UnityEngine;

public class CoinRecoveryCooldownUpgrade : MonoBehaviour
{
    private int upgradeLevel = 0; // アップグレードのレベル
    private float upgradeCost = 100f; // アップグレードのコスト
    public CoinRecovery coinRecovery;
    public CoinRecoveryCooldownUpgradTextUpdate coinRecoveryCooldownUpgradTextUpdate;

    public void UpgradeCoinRecoveryCooldown()
    {
        if (upgradeLevel >= 10) // 最大レベルに達している場合は行わない
        {
            return;
        }

        if (!CoinManager.Instance.UseCoin(Mathf.RoundToInt(upgradeCost)))
        {
            return;
        }

        upgradeLevel++;

        // 0.01秒減らして、最小0.01秒を下回らないように制御
        float newTime = CoinRecoveryManeger.Instance.RecoveryCoinTimeCount - 0.01f;
        newTime = Mathf.Max(0.01f, newTime); // 0.01秒未満になるのを防ぐ

        // 浮動小数点誤差を丸める (例: 0.08000001 -> 0.08)
        CoinRecoveryManeger.Instance.RecoveryCoinTimeCount = Mathf.Round(newTime * 100f) / 100f;

        if (coinRecovery != null)
        {
            coinRecovery.UpdateSliderMaxValue(); // スライダーの最大値を更新する
        }

        upgradeCost *= 1.5f; // 次のアップグレードコストを増加させる

        if (coinRecoveryCooldownUpgradTextUpdate != null)
        {
            coinRecoveryCooldownUpgradTextUpdate.CoinRecoveryCooldownUpgradeTextUpdate(); // テキストを更新する
        }
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