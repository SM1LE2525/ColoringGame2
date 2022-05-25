//Dice�ɃA�^�b�`
//�T�C�R���̒l���擾���鏈��

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceScript : MonoBehaviour
{
    public ShadowScript Shadow;
    public GameObject Dice;
    public int Dnum = 0;//�T�C�R���̒l
    public int Rdnum = 0;//�������i�[
    public bool DiceClick = false;
    public Animator anim; //Dice��Animator���i�[

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

        if (DiceClick == false) //�T�C�R����~��
        {
            DiceClick = true;//�T�C�R����U��
            RandomNum();
            anim.SetBool("Clickflag", true);//"Roll_Animation"�����s
            anim.SetInteger("Dicenum", Rdnum);//�T�C�R���̖ڂɉ����ăA�j���[�V�����Đ�
            Shadow.ShadowAnim();//"Shadow_Animation"�����s
        }
    }

    public void RandomNum() 
    {
            Rdnum = Random.Range(0, 6);//��������
            Dnum = Rdnum + 1;//�T�C�R���̒l
    }
}
