using UnityEngine;

public class Move_Pusher : MonoBehaviour
{
    public float speed = 1f;
    public float pusherMoveRange = 5f;
    private Vector3 startPosition;
    private Rigidbody rb ;

    // Start is called on1ce before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World");
        startPosition = this.transform.localPosition;
        //自身についているRigidbodyコンポーメントを取得して、変数rbに入れる。
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * pusherMoveRange;
        //自身のローカル座標の位置を最初の位置情報にz(sin波の変動値)を加算して返す
        //this.transform.localPosition = startPosition + new Vector3(0, 0, z);
        rb.linearVelocity = new Vector3(0,0,z);
    }
}
