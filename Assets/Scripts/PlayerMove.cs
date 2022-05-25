//Playerにアタッチ
//Playerの移動処理

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;//DOTween使用

public class PlayerMove : MonoBehaviour
{
    Vector3 playerPos;
    public GameObject player;
    public ColorCounter ColorCounter;//ColorCounterスクリプトの取得
    public DiceScript DiceScript;//サイコロの値

    public int[] pPos = { 0, 0 };
    public int count = 0;
    [SerializeField] private int ColorNum;//プレイヤーのカラー番号

    // Start is called before the first frame update
    void Start()
    {
        ColorCounter.MassCount(pPos[0],pPos[1], ColorNum);//Playerの初期位置を記録
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickUpArrow()//上に移動
    {
            playerPos = this.player.transform.position;//Playerの座標取得
                                                       //現在の座標からY+1の座標へ1秒かけて移動
            this.player.transform.DOMove(new Vector3(playerPos.x, playerPos.y + 1, 0), 1f);
            playerPos = this.player.transform.position;//Playerの座標更新

            pPos[1]--;//プレイヤーの位置を更新
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);//プレイヤーの位置の取得、カラー番号の設定
            count++;
    }

    public void ClickDownArrow() //下に移動
    {
            playerPos = this.player.transform.position;
            //現在の座標からY-1の座標へ1秒かけて移動
            this.player.transform.DOMove(new Vector3(playerPos.x, playerPos.y - 1, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[1]++;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
    }

    public void ClickRightArrow()//右に移動
    {
            playerPos = this.player.transform.position;
            //現在の座標からx+1の座標へ1秒かけて移動
            this.player.transform.DOMove(new Vector3(playerPos.x + 1, playerPos.y, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[0]++;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
            
    }

    public void ClickLeftArrow()//左に移動
    {
            playerPos = this.player.transform.position;
            //現在の座標からx-1の座標へ1秒かけて移動
            this.player.transform.DOMove(new Vector3(playerPos.x - 1, playerPos.y, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[0]--;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
    }
}

//ボタンを押せる回数をさいころなどで取得
//その後、ButtonClick変数でカウント
//ButtonClick=0でfalse
