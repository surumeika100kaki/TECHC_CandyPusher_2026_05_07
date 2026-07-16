using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Stage_Out : MonoBehaviour
{
    CreateCandy createType;
    //スコアの保存変数の作成
    private int Score = 0;

    [SerializeField] TextMeshProUGUI Score_TMP;

    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる。
    private void Start()
    {
        Score_TMP.text = $"スコア:{Score}";

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "0")
        {
            AudioManager.instance.SEPlay(1);
        } else if (other.gameObject.name == "1")
        {
            AudioManager.instance.SEPlay(2);
        } else if (other.gameObject.name == "2")
        {
            AudioManager.instance.SEPlay(3);
        }
        else if (other.gameObject.name == "3")
        {
            AudioManager.instance.SEPlay(4);
        }
        else if (other.gameObject.name == "4")
        {
            AudioManager.instance.SEPlay(5);
        }
        //すり抜けたオブジェクトを破棄
        Destroy( other.gameObject );
        //スコアを+1追加
        Score = Score + 1;

        if (Score == 100)
        {
            AudioManager.instance.BGMPlay(1);
        }
        //コンソールにスコアを表示
        Score_TMP.text = $"スコア:{Score}";
    }
}