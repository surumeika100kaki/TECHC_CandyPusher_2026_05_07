using UnityEngine;
using TMPro;

public class CoinUiUpdate : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Coin_TMP;
    void Start()
    {
        Coin_TMP.text = $"コイン:{CoinManager.Instance.GetCoin()}";
    }

    void Update()
    {
        Coin_TMP.text = $"コイン:{CoinManager.Instance.GetCoin()}";
    }
}
