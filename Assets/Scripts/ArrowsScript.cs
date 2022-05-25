//Player�ɃA�^�b�`
//���̕\��/��\�����s������

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsScript : MonoBehaviour
{
    private GameObject[] Arrows = new GameObject[4];//Arrow�I�u�W�F�N�g���i�[
    public PlayerMove PlayerMove;//PlayerMove�X�N���v�g�̎擾
    public DiceScript DiceScript;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < Arrows.Length; i++) 
        {
            //�e�����i�[
            Arrows[i] = this.transform.GetChild(i).gameObject;
            Arrows[i].SetActive(false);//���̔�\��
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DiceScript.DiceClick == true) //�T�C�R����U�����Ƃ�
        {
            if (PlayerMove.count < DiceScript.Dnum)//���̃N���b�N��<�T�C�R���̒l�̂Ƃ�
            {
                UpArrow();
                DownArrow();
                LeftArrow();
                RightArrow();
            }
            else //���̃N���b�N��>=�T�C�R���̒l�̂Ƃ�
            {
                for (int i=0; i < Arrows.Length; i++) 
                {
                    Arrows[i].SetActive(false);//���̔�\��
                }
                DiceScript.DiceClick = false;//�T�C�R����~��Ԃ�
                PlayerMove.count = 0;//�J�E���g��������
            }
        }
        //�T�C�R���̖ڂ����ړ�
        //�ړ�������ɖ��\��
    }

    private void UpArrow() //����̕\���E��\��
    {
        if (PlayerMove.pPos[1] == 0)
        {
            Arrows[0].SetActive(false);//��\��
        }
        else
        {
            Arrows[0].SetActive(true);//�\��
        }
    }

    private void DownArrow() //�����̕\���E��\��
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

    private void LeftArrow() //�����̕\���E��\��
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

    private void RightArrow() //�E���̕\���E��\��
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
