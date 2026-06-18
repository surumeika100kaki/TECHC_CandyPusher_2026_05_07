using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Stage_Out : MonoBehaviour
{
    //スコアの保存変数の作成
    private int Score = 0;

    List<string> DropCandyList = new List<string>(){};

    private int MaxLangDropCandyLog = 6;
    [SerializeField] TextMeshProUGUI Score_TMP;
    [SerializeField] Text Score_Txte_Leg;

    [SerializeField] TextMeshProUGUI DropCandyLog;

    //このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時に呼ばれる。
    private void Start()
    {
        Score_TMP.text = $"スコア:{Score}";

        Score_Txte_Leg.text = $"スコア:{Score}";

        DropCandyLog.text = "ログ:\n" + string.Join("\n",DropCandyList);
        //別解
        //Score_Text.text = "スコア：" + Score;
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name}がすり抜けた");
        //すり抜けたオブジェクトを破棄
        Destroy( other.gameObject );
        //スコアを+1追加
        Score = Score + 1;
        //別解
        //Score += 1;
        //コンソールにスコアを表示
        //Debug.Log($"スコア：{Score}");
        Score_TMP.text = $"スコア:{Score}";
        Score_Txte_Leg.text = $"スコア:{Score}";

        if(DropCandyList.Count > MaxLangDropCandyLog)
        {
            DropCandyList.RemoveAt(0);
            DropCandyList.Add(other.name);
        }
        else
        {
            DropCandyList.Add(other.name);
        }
        DropCandyLog.text = "ログ:\n" + string.Join("\n",DropCandyList);;
    }
}