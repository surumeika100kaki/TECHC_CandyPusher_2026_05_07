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
    //初期のpositionを格納する変数
    private Vector3 startPosition;
    //動いて何秒目かを格納する変数
    private float MoveTiamer = 1;   
    //z方向に動いている時間を格納する変数
    private float z_Movetime = 0;
    //ｚ軸の増加量を格納する変数；
    private float z = 0;

    //キャンディーを何秒に一回生成するかを格納する変数
    public float CreateTaimer_Rimit = 1;
    //キャンディーの生成から何秒かを格納する変数
    private float CreateTaimer = 0;
    //生成されたキャンディーの個数を格納する変数
    private int CandyCount = 0;

    //生成するキャンディーを格納する配列
    public GameObject[] Candy;

    void Start()
    {
        //自身の初期positionをstartPositionに格納
        startPosition = transform.position;
    }

        void Update()
    {   
        MoveCandyGenerate();

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }

        if( CreateTaimer >= CreateTaimer_Rimit){
            AddCandy();
            CreateTaimer = 0;
        }
        CreateTaimer += Time.deltaTime;
    }

    private void AddCandy()
    {
        for(int i = 0; i < 3 ; i++){
        CandyCount++;
        Debug.Log(CandyCount);
        //CandyCount = CandyCount + 1;
        
        int rand = Random.Range(0,100);
        int candyType = 0;
        //それぞれの当選確率
        if(rand < 5){
            candyType = 0;
        }
        else if(rand < 70){
            candyType = 1;
        }else if(rand < 80){
            candyType = 2;
        }else{
            candyType = 3;
        }
        GameObject createPrefab = Instantiate(Candy[candyType]);
        //GameObject createPrefab = Instantiate(Candy[Random.Range(0,Candy.Count)]);
        createPrefab.transform.position = this.transform.position;
        }
    }

    private void MoveCandyGenerate()
    {
        //Time.time * (2*Mathf.PI)は一周が一秒になり、(2*Mathf.PI)にspeedをかけることでspeed倍の時間で一周する
        float x = Mathf.Sin( Time.time * ((2*Mathf.PI) * x_speed))*x_MoveRange;

        if (MoveTiamer >3 && MoveTiamer <4)
        {
            z = Mathf.Sin( z_Movetime * (2*Mathf.PI) * z_speed)*z_MoveRange;
            z_Movetime += Time.deltaTime;
        }else if(MoveTiamer > 4){
            MoveTiamer = 1;
        } 
        MoveTiamer += Time.deltaTime;
        this.transform.position = startPosition + new Vector3(x,0,z);   
    }
}
