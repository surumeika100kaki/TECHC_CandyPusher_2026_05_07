using UnityEngine;
using System.Collections.Generic;

public class CandyManager : MonoBehaviour
{
    public static CandyManager Instance;

    private Dictionary<CandyType, int> candyCounts
        = new Dictionary<CandyType, int>();

    private void Awake()
    {
        Instance = this;

        // 8種類を初期化
        foreach (CandyType type in System.Enum.GetValues(typeof(CandyType)))
        {
            candyCounts[type] = 0;
        }
    }

    // キャンディを増やす
    public void AddCandy(CandyType type, int amount)
    {
        candyCounts[type] += amount;

        Debug.Log(type + " +" + amount);
    }

    // キャンディを消費する
    public bool UseCandy(CandyType type, int amount)
    {
        if (candyCounts[type] < amount)
        {
            Debug.Log(type + " が足りません");
            return false;
        }

        candyCounts[type] -= amount;

        Debug.Log(type + " -" + amount);

        return true;
    }

    // 現在の所持数を取得
    public int GetCandy(CandyType type)
    {
        return candyCounts[type];
    }
}