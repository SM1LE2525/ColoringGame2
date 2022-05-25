//MassObjectにアタッチ
//プレイヤーのカラー番号の数をカウントする処理

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCounter : MonoBehaviour
{
    public int[,] pColor = new int[8,8];
    public int[] massCount = new int[4];//4人分のカウンターを用意

    // Start is called before the first frame update
    void Start()
    {
        //各マスのカラー番号を初期化
        for (int i = 0; i < pColor.GetLength(0); i++)
        {
            for (int j = 0; j < pColor.GetLength(1); j++)
            {
                pColor[i, j] = 0;
            }
        }

        for(int i = 0; i < massCount.Length; i++)//プレイヤーのカウンターを初期化
        {
            massCount[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //各プレイヤーの色を数える際に使用
    public void MassCount(int pPosX,int pPosY, int Colornum)
    {
        //歩いた場所にプレイヤーのカラー番号を設定
        pColor[pPosY, pPosX] = Colornum;
        test();
        ColorCheck();
    }

    //マスの状態をConsoleで表示
    public void test()
    {
        string test = "\n";

        for (int i = 0; i < pColor.GetLength(0); i++)
        {
            for (int j = 0; j < pColor.GetLength(1); j++)
            {
                test += pColor[i, j] + " ";
            }
            test += "\n";
        }
        //print(test);
    }

    public void ColorCheck() //マス全体のカラー番号をチェック
    {
        for (int i = 0; i < massCount.Length; i++)
        {
            massCount[i] = 0;
        }

        for (int i = 0; i < pColor.GetLength(0); i++)
        {
            for (int j = 0; j < pColor.GetLength(1); j++)
            {
                /*
                if (pColor[i, j] == 1) 
                {
                    massCount[0] += 1;
                }
                */

                switch (pColor[i, j])   //各マスのプレイヤーカラーを検索
                {
                    case 1:
                        massCount[0]++;
                        break;
                    case 2:
                        massCount[1]++;
                        break;
                    case 3:
                        massCount[2]++;
                        break;
                    case 4:
                        massCount[3]++;
                        break;
                    default:
                        break;
                }

            }
        }

        //print("1Pの数:"+massCount[0]);
        //print("2Pの数:"+massCount[1]);
        //print("3Pの数:"+massCount[2]);
        //print("4Pの数:"+massCount[3]);
    }

}
