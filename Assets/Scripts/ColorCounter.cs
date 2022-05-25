//MassObject�ɃA�^�b�`
//�v���C���[�̃J���[�ԍ��̐����J�E���g���鏈��

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCounter : MonoBehaviour
{
    public int[,] pColor = new int[8,8];
    public int[] massCount = new int[4];//4�l���̃J�E���^�[��p��

    // Start is called before the first frame update
    void Start()
    {
        //�e�}�X�̃J���[�ԍ���������
        for (int i = 0; i < pColor.GetLength(0); i++)
        {
            for (int j = 0; j < pColor.GetLength(1); j++)
            {
                pColor[i, j] = 0;
            }
        }

        for(int i = 0; i < massCount.Length; i++)//�v���C���[�̃J�E���^�[��������
        {
            massCount[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�e�v���C���[�̐F�𐔂���ۂɎg�p
    public void MassCount(int pPosX,int pPosY, int Colornum)
    {
        //�������ꏊ�Ƀv���C���[�̃J���[�ԍ���ݒ�
        pColor[pPosY, pPosX] = Colornum;
        test();
        ColorCheck();
    }

    //�}�X�̏�Ԃ�Console�ŕ\��
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

    public void ColorCheck() //�}�X�S�̂̃J���[�ԍ����`�F�b�N
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

                switch (pColor[i, j])   //�e�}�X�̃v���C���[�J���[������
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

        //print("1P�̐�:"+massCount[0]);
        //print("2P�̐�:"+massCount[1]);
        //print("3P�̐�:"+massCount[2]);
        //print("4P�̐�:"+massCount[3]);
    }

}
