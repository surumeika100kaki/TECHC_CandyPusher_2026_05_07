using UnityEngine;
using UnityEngine.UI;

public class CoinRecovery : MonoBehaviour
{
    [SerializeField] private Slider targetSlider; // 連動させるスライダー
    private float timer = 0f; // 0.1秒を測るためのタイマーカウンター
    public float MaxValue = 100f;

    void Start()
    {
        if (targetSlider != null)
        {
            targetSlider.maxValue = MaxValue;
            targetSlider.value = MaxValue;
        }
    }

    void Update()
    {
        if (targetSlider == null) return;

        // GetCoin の後ろに () を追加
        if (targetSlider.value >= MaxValue && CoinManager.Instance.GetCoin() >= CoinManager.Instance.CoinCost * 100)
        {
            return;
        }

        timer += Time.deltaTime;

        // タイマーが0.1秒を超えたら処理を実行
        if (timer >= 0.1f)
        {
            // スライダーの値を1増やす
            targetSlider.value += 1f;

            // 0.1秒分だけタイマーを引く
            timer -= 0.1f;

            if (targetSlider.value >= MaxValue)
            {
                if (CoinManager.Instance.GetCoin() < CoinManager.Instance.CoinCost * 100)
                {
                    targetSlider.value = 0f;
                    CoinManager.Instance.AddCoin(RecoveryCoinIncrease);
                }
            }
        }
    }
}
