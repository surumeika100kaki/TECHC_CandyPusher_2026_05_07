using UnityEngine;
using System.Collections.Generic;
public class CoinMultiplierManager : MonoBehaviour
{
    public static CoinMultiplierManager Instance;
    private Dictionary<CandyType, float> candyMultipliers = new Dictionary<CandyType, float>();
    private void Awake()
    {
        Instance = this;

        // 1. typeof(CandyType)で
        // CandyType（列挙型）に定義されているすべての定義値（種類）を配列として一覧取得する
        // 2. foreach (CandyType type in System.Enum.GetValues()で
        // 取得した各種類（CandyType）をひとつずつ取り出し、変数 type に代入しながら繰り返し処理を行う
        foreach (CandyType type in System.Enum.GetValues(typeof(CandyType)))
        {
            // 3. 取り出した種類をキーとして、Dictionary（candyMultipliers）に初期倍率 1.0f（1.0倍）を設定する
            candyMultipliers[type] = 1.0f;
        }
    }
    public float GetMultiplier(CandyType type)
    {
        return candyMultipliers[type];
    }
    public void AddMultiplier(CandyType type, float value)
    {
        candyMultipliers[type] += value;
    }
}
