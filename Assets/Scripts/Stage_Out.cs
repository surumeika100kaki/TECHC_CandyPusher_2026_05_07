using TMPro;
using UnityEngine;

public class Stage_Out : MonoBehaviour
{
    //スコアの保存変数の作成
    private int Score = 0;
    public AudioManager audioManager;

    [SerializeField] TextMeshProUGUI Score_TMP;

    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる。
    private void Start()
    {
        Score_TMP.text = $"スコア:{Score}";

    }
    private void OnTriggerEnter(Collider other)
    {
        //すり抜けたオブジェクトを破棄
        Destroy( other.gameObject );
        //スコアを+1追加
        Score = Score + 1;
        audioManager.SEPlay(0);

        //コンソールにスコアを表示
        Score_TMP.text = $"スコア:{Score}";
    }
}