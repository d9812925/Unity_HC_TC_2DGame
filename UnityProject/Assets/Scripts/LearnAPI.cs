﻿using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    public int speed = 0;

    // 非靜態需要先定義欄位，並且在屬性面板上套用對應物件
    public Transform bird;
    public Transform ground;

    private void Start()
    {
        Debug.Log("一般!");
        Debug.LogWarning("警告!");
        Debug.LogError("錯誤!");

        Debug.Log(Mathf.PI);

        // 靜態屬性 static properties
        Debug.Log(Random.value);
        // 靜態方法 static method 
        Debug.Log(Random.Range(1, 10));

        // 非靜態屬性用法 properties
        Debug.Log(bird.position);
        Debug.Log(ground.position);
    }
}
