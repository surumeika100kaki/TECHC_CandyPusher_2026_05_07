using UnityEngine;

public class CoinRecoveryManeger : MonoBehaviour
{
    public static CoinRecoveryManeger Instance;

    public int RecoveryCoinIncrease = 1;
    public float RecoveryCoinTimeCount = 0.1f; // 初期値を0.1秒に設定

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float GetRecoveryTime()
    {
        return RecoveryCoinTimeCount;
    }
}