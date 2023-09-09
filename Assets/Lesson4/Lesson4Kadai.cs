using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4Kadai : MonoBehaviour
{
    void Start()
    {
        // 配列を初期化
        int[] points = {10, 20, 30, 40, 50};

        // 配列の要素数のぶんだけ処理を繰り返す
        for(int i = 0; i < points.Length; i++)
        {
            UnityEngine.Debug.Log(points[i]);
        }

        //逆順で表示
        for(int i = points.Length -1; i >= 0; i--)
        {
            UnityEngine.Debug.Log(points[i]);
        }
    }

    void Update()
    {

    }

}