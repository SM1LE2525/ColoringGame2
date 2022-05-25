//Playerにアタッチ
//矢印の表示/非表示を行う処理

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsScript : MonoBehaviour
{
    private GameObject[] Arrows = new GameObject[4];//Arrowオブジェクトを格納
    public PlayerMove PlayerMove;//PlayerMoveスクリプトの取得
    public DiceScript DiceScript;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < Arrows.Length; i++) 
        {
            //各矢印を格納
            Arrows[i] = this.transform.GetChild(i).gameObject;
            Arrows[i].SetActive(false);//矢印の非表示
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DiceScript.DiceClick == true) //サイコロを振ったとき
        {
            if (PlayerMove.count < DiceScript.Dnum)//矢印のクリック数<サイコロの値のとき
            {
                UpArrow();
                DownArrow();
                LeftArrow();
                RightArrow();
            }
            else //矢印のクリック数>=サイコロの値のとき
            {
                for (int i=0; i < Arrows.Length; i++) 
                {
                    Arrows[i].SetActive(false);//矢印の非表示
                }
                DiceScript.DiceClick = false;//サイコロ停止状態へ
                PlayerMove.count = 0;//カウントを初期化
            }
        }
        //サイコロの目だけ移動
        //移動完了後に矢印表示
    }

    private void UpArrow() //上矢印の表示・非表示
    {
        if (PlayerMove.pPos[1] == 0)
        {
            Arrows[0].SetActive(false);//非表示
        }
        else
        {
            Arrows[0].SetActive(true);//表示
        }
    }

    private void DownArrow() //下矢印の表示・非表示
    {
        if (PlayerMove.pPos[1] == 7)
        {
            Arrows[1].SetActive(false);
        }
        else
        {
            Arrows[1].SetActive(true);
        }
    }

    private void LeftArrow() //左矢印の表示・非表示
    {
        if (PlayerMove.pPos[0] == 0)
        {
            Arrows[2].SetActive(false);
        }
        else
        {
            Arrows[2].SetActive(true);
        }
    }

    private void RightArrow() //右矢印の表示・非表示
    {
        if (PlayerMove.pPos[0] == 7)
        {
            Arrows[3].SetActive(false);
        }
        else
        {
            Arrows[3].SetActive(true);
        }
    }
}
