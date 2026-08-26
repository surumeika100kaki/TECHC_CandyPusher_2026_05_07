using UnityEngine;

public class CandyRotate : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(Vector3.up * Time.deltaTime * 50f);
    }
}
