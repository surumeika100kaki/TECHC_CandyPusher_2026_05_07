using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CreateCandy : MonoBehaviour
{
    public GameObject[] candyPrefabs;
    public Transform dropPoint;
    public int dropCost = 1;

    public void DropCandy()
    {
        // コインを消費できるか確認
        if (!CoinManager.Instance.UseCoin(dropCost))
        {
            return;
        }

        // ランダムなキャンディを選択
        int index = Random.Range(0, candyPrefabs.Length);

        // キャンディ生成
        Instantiate(
            candyPrefabs[index],
            dropPoint.position,
            Quaternion.identity
        );
        AudioManager.instance.SEPlay(0);
    }
}
