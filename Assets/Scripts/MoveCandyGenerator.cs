using UnityEngine;

public class MoveCandyGeneretor : MonoBehaviour
{

    //x‚Ì‰•œ‚Ü‚Å‚Ì‘¬“xN•b‚ðŠi”[‚·‚é•Ï”
    public float x_speed = 1f;
    //z‚Ì‰•œ‚Ü‚Å‚Ì‘¬“xN•b‚ðŠi”[‚·‚é•Ï”
    public float z_speed = 1f;
    //‚Ç‚±‚Ü‚ÅXÀ•W‚ªˆÚ“®‚·‚é‚©‚ðŠi”[‚·‚é•Ï”
    public float x_MoveRange = 2.5f;
    //‚Ç‚±‚Ü‚ÅZÀ•W‚ªˆÚ“®‚·‚é‚©‚ðŠi”[‚·‚é•Ï”
    public float z_MoveRange = 2.5f;
    //“®‚¢‚Ä‰½•b–Ú‚©‚ðŠi”[‚·‚é•Ï”
    private float MoveTiamer = 1;
    //z•ûŒü‚É“®‚¢‚Ä‚¢‚éŽžŠÔ‚ðŠi”[‚·‚é•Ï”
    private float z_Movetime = 0;
    //‚šŽ²‚Ì‘‰Á—Ê‚ðŠi”[‚·‚é•Ï”G
    private float z = 0;

    public void MoveCandyGenerate(Vector3 startPosition)
    {
        //Time.time * (2*Mathf.PI)‚ÍˆêŽü‚ªˆê•b‚É‚È‚èA(2*Mathf.PI)‚Éspeed‚ð‚©‚¯‚é‚±‚Æ‚Åspeed”{‚ÌŽžŠÔ‚ÅˆêŽü‚·‚é
        float x = Mathf.Sin(Time.time * ((2 * Mathf.PI) * x_speed)) * x_MoveRange;

        if (MoveTiamer > 3 && MoveTiamer < 4)
        {
            z = Mathf.Sin(z_Movetime * (2 * Mathf.PI) * z_speed) * z_MoveRange;
            z_Movetime += Time.deltaTime;
        }
        else if (MoveTiamer > 4)
        {
            MoveTiamer = 1;
        }
        MoveTiamer += Time.deltaTime;
        this.transform.position = startPosition + new Vector3(x, 0, z);
    }
}
