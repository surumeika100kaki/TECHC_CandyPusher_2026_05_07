using TMPro;
using UnityEngine;

public class Stage_Out : MonoBehaviour
{
    //スコアの保存変数の作成
    private int Score = 0;
    [SerializeField] TextMeshProUGUI Score_Text;
    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる。
    private void Start()
    {
        Score_Text.text = $"スコア:{Score}";
        //別解
        //Score_Text.text = "スコア：" + Score;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name}がすり抜けた");
        //すり抜けたオブジェクトを破棄
        Destroy( other.gameObject );
        //スコアを+1追加
        Score = Score + 1;
        //別解
        //Score += 1;
        //コンソールにスコアを表示
        Debug.Log($"スコア：{Score}");
        Score_Text.text = $"スコア:{Score}";
    }
}