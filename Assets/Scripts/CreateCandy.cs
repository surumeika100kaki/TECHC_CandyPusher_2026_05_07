using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreateCandy : MonoBehaviour
{
    public float speed = 2*Mathf.PI;
    public float CreateCandy_MoveRange_x = 5f;
    public float CreateCandy_MoveRange_z = 5f;
    private Vector3 stastartPosition;

    private int move_count = 0;

    private int CandyCount = 0;

    public List<GameObject> Candy;

    void Start()
    {
        stastartPosition = transform.position;
    }

        void Update()
    {
        float z = stastartPosition.z;
        float x = Mathf.Sin(Time.time * speed) * CreateCandy_MoveRange_x;
        z = Mathf.Sin(Time.time * speed) * CreateCandy_MoveRange_z;

        this.transform.position = stastartPosition+new Vector3(x,0,z);
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            AddCandy();
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    AddCandy();
        //}
    }

    private void AddCandy()
    {
        CandyCount++;
        Debug.Log(CandyCount);
        //•Ê‰ð
        //CandyCount = CandyCount + 1;
        GameObject createPrefab = Instantiate(Candy[Random.Range(0,Candy.Count)]);
        createPrefab.transform.position = this.transform.position;
    }
}
