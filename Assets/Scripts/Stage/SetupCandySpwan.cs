using UnityEngine;

public class SetupCandySpwan : MonoBehaviour
{
    public GameObject[] candyPrefabs;
    public Transform dropPoint;

    void Start()
    {
        // このスクリプトが付いているオブジェクトを基準にする
        dropPoint = this.transform;

        // 基準位置を保存
        Vector3 basePosition = dropPoint.position;

        // 1つ目のキャンディ配置
        SetCandy(basePosition, 1);

        // X座標を反転した位置に、全く同じ配置を作る
        Vector3 reversePosition = new Vector3(
            -basePosition.x,
            basePosition.y,
            basePosition.z
        );

        // 2つ目のキャンディ配置
        SetCandy(reversePosition, -1);
    }

    public void SetCandy(Vector3 basePosition,int xDirection)
    {
        // キャンディリストが設定されていない場合
        if (candyPrefabs == null || candyPrefabs.Length == 0)
        {
            Debug.LogError("candyPrefabsが設定されていません");
            return;
        }

        for (int i = 0; i < 200; i++)
        {
            // Z方向の列
            int zIndex = i / 20;

            // X方向の位置
            int xIndex = i % 20;

            // キャンディ生成位置
            Vector3 spawnPosition = new Vector3(
                basePosition.x + xIndex * 1.5f * xDirection,
                basePosition.y,
                basePosition.z - zIndex * 1.5f
            );

            // ランダムなキャンディを選択
            int index = Random.Range(0, candyPrefabs.Length);

            // キャンディ生成
            Instantiate(
                candyPrefabs[index],
                spawnPosition,
                Quaternion.identity
            );
        }
    }
}