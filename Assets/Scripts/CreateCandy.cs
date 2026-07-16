using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CreateCandy : MonoBehaviour
{
    private Vector3 startPosition;

    //キャンディーを何秒に一回生成するかを格納する変数
    public float CreateTaimer_Rimit = 1;
    //キャンディーの生成から何秒かを格納する変数
    private float CreateTaimer = 0;
    //生成されたキャンディーの個数を格納する変数
    private int CandyCount = 0;

    //生成するキャンディーを格納する配列
    public GameObject[] Candy;

    public MoveCandyGeneretor moveCandyGeneretor;

    void Start()
    {
        //自身の初期positionをstartPositionに格納
        startPosition = transform.position;
        for (int i = 0; i < 100; i++)
        {
            AddCandy();
        }
    }

        void Update()
    {
        moveCandyGeneretor.MoveCandyGenerate(startPosition);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
            AudioManager.instance.SEPlay(0);
        }

        if( CreateTaimer >= CreateTaimer_Rimit){
            AddCandy();
            CreateTaimer = 0;
        }
        CreateTaimer += Time.deltaTime;
    }

    public void AddCandy()
    {

        CandyCount++;

        //Debug.Log(CandyCount);
        //CandyCount = CandyCount + 1;

        int rand = Random.Range(0,100);
        int candyType = 0;
        //それぞれの当選確率
        if (rand < 10)
        {
            candyType = 0;
        }
        else if (rand < 50)
        {
            candyType = 1;
        }
        else if (rand < 75)
        {
            candyType = 2;
        }
        else if (rand < 90)
        {
            candyType = 3;
        }
        else
        {
            candyType = 4;
        }
            GameObject createPrefab = Instantiate(Candy[candyType]);
        //GameObject createPrefab = Instantiate(Candy[Random.Range(0,Candy.Count)]);
        createPrefab.transform.position = this.transform.position;
        createPrefab.name = candyType.ToString();

    }
}
