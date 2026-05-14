using UnityEngine;

public class Move_Pusher : MonoBehaviour
{
    public float speed = 1f;
    public float pusherMoveRange = 5f;
    private Vector3 startPosition;
    // Start is called on1ce before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * pusherMoveRange;
        //自身のローカル座標の位置を最初の位置情報にz(sin波の変動値)を加算して返す
        this.transform.localPosition = startPosition + new Vector3(0, 0, z);
    }
}
