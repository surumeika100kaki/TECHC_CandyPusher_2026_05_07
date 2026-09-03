using UnityEngine;
using System.Collections.Generic;

public class CoinMultiplierManager : MonoBehaviour
{
    public static CoinMultiplierManager Instance;
    private Dictionary<CandyType, float> candyMultipliers = new Dictionary<CandyType, float>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // 各キャンディの種類に応じた初期倍率を設定
        InitializeMultipliers();
    }

    private void InitializeMultipliers()
    {
        // 正方形キャンディ
        candyMultipliers[CandyType.ChocoMint] = 8.0f;
        candyMultipliers[CandyType.Strawberry] = 8.0f;
        candyMultipliers[CandyType.Lemon] = 5.0f;
        candyMultipliers[CandyType.Orange] = 5.0f;

        // 球形キャンディ
        candyMultipliers[CandyType.SphereChocoMint] = 3.0f;
        candyMultipliers[CandyType.SphereStrawberry] = 3.0f;
        candyMultipliers[CandyType.SphereLemon] = 1.0f;
        candyMultipliers[CandyType.SphereOrange] = 1.0f;
    }

    public float GetMultiplier(CandyType type)
    {
        if (candyMultipliers.TryGetValue(type, out float value))
        {
            return value;
        }
        return 1.0f; // 万が一取得できなかった場合のデフォルト値
    }

    public void AddMultiplier(CandyType type, float value)
    {
        if (candyMultipliers.ContainsKey(type))
        {
            candyMultipliers[type] += value;
        }
    }
}