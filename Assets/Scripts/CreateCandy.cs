using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CreateCandy : MonoBehaviour
{
    //xの往復までの速度N秒を格納する変数
    public float x_speed = 1f;
    //zの往復までの速度N秒を格納する変数
    public float z_speed = 1f;
    //どこまでX座標が移動するかを格納する変数
    public float x_MoveRange = 2.5f;
    //どこまでZ座標が移動するかを格納する変数
    public float z_MoveRange = 2.5f;
    //動いて何秒目かを格納する変数
    private float MoveTiamer = 1;
    //z方向に動いている時間を格納する変数
    private float z_Movetime = 0;
    //ｚ軸の増加量を格納する変数；
    private float z = 0;
    private Vector3 startPosition;

    //キャンディーを何秒に一回生成するかを格納する変数
    public float CreateTaimer_Rimit = 1;
    //キャンディーの生成から何秒かを格納する変数
    private float CreateTaimer = 0;
    //生成されたキャンディーの個数を格納する変数
    private int CandyCount = 0;

    //生成するキャンディーを格納する配列
    public GameObject[] Candy;

    public AudioManager audioManager;
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
            audioManager.SEPlay(1);
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

    }
}
