using UnityEngine;

public class CandyDropperUpdate : MonoBehaviour
{
    private Vector3 startPosition;
    private MoveCandyGeneretor moveCandyGeneretor;
    private CreateCandy createCandy;

    void Start()
    {
        createCandy = GetComponent<CreateCandy>();
        moveCandyGeneretor = GetComponent<MoveCandyGeneretor>();
        //自身の初期positionをstartPositionに格納
        startPosition = transform.position;
    }
    void Update()
    {
        moveCandyGeneretor.MoveCandyGenerate(startPosition);
    }
}
