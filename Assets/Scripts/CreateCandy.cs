using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CreateCandy : MonoBehaviour
{
    //往復までの速度を一秒にする
    private float speed = 2*Mathf.PI;
    private float CreateCandy_MoveRange_x = 2.5f;
    private float CreateCandy_MoveRange_z = 2.5f;
    private Vector3 startPosition;
    public TextMeshProUGUI Count_Timer;

    private int CandyCount = 0;

    public List<GameObject> Candy;

    void Start()
    {
        startPosition = transform.position;
    }

        void Update()
    {
        MoveCandyGenerate();
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
        Count_Timer.text = (Time.time % 3).ToString();
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    AddCandy();
        //}

        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0.2f;
        }

        // Oキーで通常速度に戻す (等倍速)
        if (Input.GetKeyDown(KeyCode.O))
        {
            Time.timeScale = 1.0f;
        }
    }

    private void AddCandy()
    {
        CandyCount++;
        Debug.Log(CandyCount);
        //CandyCount = CandyCount + 1;
        GameObject createPrefab = Instantiate(Candy[Random.Range(0,Candy.Count)]);
        createPrefab.transform.position = this.transform.position;
    }

    private void MoveCandyGenerate()
    {
        float z = 0;
        float x = Mathf.Sin(Time.time * speed)*CreateCandy_MoveRange_x;

        if (Time.time % 3 > 2)
        {
            z = Mathf.Sin(Time.time * speed)*CreateCandy_MoveRange_z;
            Debug.Log($"A _ time % 3 = {Time.time % 3} _ z = {z} _ x = {x}");
        }else
        {
            Debug.Log($"B _ time % 3 = {Time.time % 3} _ z = {z} _ x = {x}");
        }
        this.transform.position = startPosition+new Vector3(x,0,z);    
    }
}
