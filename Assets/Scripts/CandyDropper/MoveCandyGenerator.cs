using UnityEngine;

public class MoveCandyGeneretor : MonoBehaviour
{

    public float x_speed = 1f;
    public float z_speed = 1f;
    public float x_MoveRange = 2.5f;
    public float z_MoveRange = 2.5f;
    private float MoveTiamer = 1;
    private float z_Movetime = 0;
    private float z = 0;

    public void MoveCandyGenerate(Vector3 startPosition)
    {
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
