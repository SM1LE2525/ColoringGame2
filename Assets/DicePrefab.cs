//EventManagerにアタッチ
//DiceObjectを生成する

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DicePrefab : MonoBehaviour
{
    public bool Createflag = true;//ターンの始めかどうか確認するフラグ
    public GameObject DiceObject;//"DiceObject"のPrefabを格納
    public GameObject canvas;//表示させるためのCanvasを格納
    void Start()
    {

    }

    void Update()
    {
        if (Createflag == true)
        {
            //プレハブをもとにオブジェクトを生成
            GameObject DiceObject_clone = (GameObject)Instantiate(DiceObject, Vector3.zero, Quaternion.identity);
            //Canvasの子オブジェクトに設定
            DiceObject_clone.transform.SetParent(canvas.transform, false);
            Createflag = false;
        }
    }
}
