using TMPro;
using UnityEngine;

public class Stage_Out : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Score_TMP;

    private void OnTriggerEnter(Collider other)
    {
        // Candyコンポーネントを取得
        Candy candy = other.GetComponent<Candy>();

        // キャンディー以外なら処理しない
        if (candy == null)
        {
            return;
        }

        // キャンディーの種類によって処理を分ける
        switch (candy.candyType)
        {
            case CandyType.ChocoMint:
                AudioManager.instance.SEPlay(1);
                break;

            case CandyType.Strawberry:
                AudioManager.instance.SEPlay(2);
                break;

            case CandyType.Lemon:
                AudioManager.instance.SEPlay(3);
                break;

            case CandyType.Orange:
                AudioManager.instance.SEPlay(4);
                break;

            case CandyType.SphereChocoMint:
                AudioManager.instance.SEPlay(5);
                break;

            case CandyType.SphereStrawberry:
                AudioManager.instance.SEPlay(6);
                break;

            case CandyType.SphereLemon:
                AudioManager.instance.SEPlay(7);
                break;

            case CandyType.SphereOrange:
                AudioManager.instance.SEPlay(8);
                break;
        }

        // キャンディーを破棄
        Destroy(other.gameObject);
        // コインの倍率を取得
        float multiplier = CoinMultiplierManager.Instance.GetMultiplier(candy.candyType);
        // コインの増加量を計算
        int getCoin = Mathf.RoundToInt(
        CoinManager.Instance.CoinIncrease * multiplier
        );
        // コイン獲得
        CoinManager.Instance.AddCoin(getCoin);

        // コイン1000到達
        if (CoinManager.Instance.GetCoin() == 1000)
        {
            AudioManager.instance.BGMPlay(1);
        }
    }
}