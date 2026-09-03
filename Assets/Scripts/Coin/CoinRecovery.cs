using UnityEngine;
using UnityEngine.UI;

public class CoinRecovery : MonoBehaviour
{
    [SerializeField] private Slider targetSlider;
    private float currentTime = 0f;
    private const float MAX_SLIDER_VALUE = 100f;

    private void Start()
    {
        UpdateSliderMaxValue();
        if (targetSlider != null)
        {
            targetSlider.value = 0f;
        }
    }

    private void Update()
    {
        if (targetSlider == null || CoinRecoveryManeger.Instance == null)
            return;

        // コインが上限に達している場合は回復しない
        if (CoinManager.Instance.GetCoin() >= CoinManager.Instance.CoinCost * 100 && targetSlider.value <= MAX_SLIDER_VALUE)
        {
            currentTime = 0f;
            return;
        }

        // 経過時間を加算
        currentTime += Time.deltaTime;

        // 現在設定されている回復間隔（0.1秒 〜 0.01秒）を取得
        float interval = CoinRecoveryManeger.Instance.RecoveryCoinTimeCount;

        // 設定間隔ごとにスライダーの値を進める
        if (currentTime >= interval)
        {
            targetSlider.value += 1f;
            currentTime -= interval; // 精度を落とさないよう超過分を引き算
        }

        // スライダーが最大まで溜まったらコインを獲得してリセット
        if (targetSlider.value >= MAX_SLIDER_VALUE)
        {
            targetSlider.value = 0f;
            CoinManager.Instance.AddCoin(
                CoinRecoveryManeger.Instance.RecoveryCoinIncrease
            );
        }
    }

    public void UpdateSliderMaxValue()
    {
        if (targetSlider != null)
        {
            targetSlider.maxValue = MAX_SLIDER_VALUE;
        }
    }
}