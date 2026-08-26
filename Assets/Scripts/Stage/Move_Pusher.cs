using UnityEngine;

public class Move_Pusher : MonoBehaviour
{
    public float speed = 1f;
    public float pusherMoveRange = 5f;
    private Rigidbody rb ;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Mathf.Sin(Time.time * speed) * pusherMoveRange;
        rb.linearVelocity = new Vector3(0,0,z);
    }
}
