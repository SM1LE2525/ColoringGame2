//Diceにアタッチ
//サイコロの値を取得する処理

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public ShadowScript Shadow;
    public GameObject Dice;
    public int Dnum = 0;//サイコロの値
    public int Rdnum = 0;//乱数を格納
    public bool DiceClick = false;
    public Animator anim; //DiceのAnimatorを格納

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickDice()
    {

        if (DiceClick == false) //サイコロ停止中
        {
            DiceClick = true;//サイコロを振る
            RandomNum();
            anim.SetBool("Clickflag", true);//"Roll_Animation"を実行
            anim.SetInteger("Dicenum", Rdnum);//サイコロの目に応じてアニメーション再生
            Shadow.ShadowAnim();//"Shadow_Animation"を実行
        }
    }

    public void RandomNum() 
    {
            Rdnum = Random.Range(0, 6);//乱数生成
            Dnum = Rdnum + 1;//サイコロの値
    }
}
