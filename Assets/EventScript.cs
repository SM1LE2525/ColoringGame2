//EventManagerにアタッチ
//ゲームの進行を管理するスクリプト

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript : MonoBehaviour
{
    private bool Startflag = true;
    public GameObject DiceObject;

    void Start()
    {
            DiceObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Startflag == true) 
        {
            Startflag = false;
            StartCoroutine(EventStart());
        }
    }

    private IEnumerator EventStart()
    {
        print("ゲームを始める順番を決めてください");
        yield return new WaitForSeconds(1.0f);
        print("ゲームスタート");
        yield return new WaitForSeconds(1.0f);
        print("サイコロを振ってください");
        DiceObject.gameObject.SetActive(true);

    }
}


//プレイヤーの順番を決める/*後日*/
//ラベルの表示、アニメーション
//サイコロの表示・非表示
//各プレイヤーへの操作割り当て

