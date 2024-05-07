using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPre; // 敵のプレハブを保存する変数
    float delta; // 経過時間計算用
    float Span;
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        Span = 1;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > Span)
        {
            //  時間経過を保存している変数を０にクリアする
            delta = 0;

            // 敵を出す間隔を徐々に短くする
            Span -= 0.01f;
            // 敵を生成する
            GameObject go = Instantiate(EnemyPre);
            int py = Random.Range(-6, 7);
            go.transform.position = new Vector3(10, py, 0);

 
        }
    }
}
