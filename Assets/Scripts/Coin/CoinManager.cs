using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    public CoinUiUpdate coinUiUpdate;
    public int coin = 1000;
    public int CoinCost = 1;
    public int CoinIncrease = 1;
    private void Awake()
    {
        Instance = this;
    }

    // コインを増やす
    public void AddCoin(int amount)
    {
        coin += amount;
        
        coinUiUpdate.UpdateCoinDisplay();
    }

    // コインを消費する
    public bool UseCoin(int amount)
    {
        if (coin < amount)
        {
            Debug.Log("コインが足りません");
            return false;
        }

        coin -= amount;

        Debug.Log("コイン -" + amount);

        coinUiUpdate.UpdateCoinDisplay();
        return true;
    }

    // 現在のコイン数
    public int GetCoin()
    {
        return coin;
    }
}