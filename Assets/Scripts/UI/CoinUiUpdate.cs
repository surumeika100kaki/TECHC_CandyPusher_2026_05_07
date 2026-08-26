using UnityEngine;
using TMPro;

public class CoinUiUpdate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Coin_TMP;
    void Start()
    {
        UpdateCoinDisplay();
    }

    public void UpdateCoinDisplay()
    {
        Coin_TMP.text = $"コイン:{CoinManager.Instance.GetCoin()}";
    }
}
