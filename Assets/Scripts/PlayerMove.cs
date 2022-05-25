//Player�ɃA�^�b�`
//Player�̈ړ�����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;//DOTween�g�p

public class PlayerMove : MonoBehaviour
{
    Vector3 playerPos;
    public GameObject player;
    public ColorCounter ColorCounter;//ColorCounter�X�N���v�g�̎擾
    public DiceScript DiceScript;//�T�C�R���̒l

    public int[] pPos = { 0, 0 };
    public int count = 0;
    [SerializeField] private int ColorNum;//�v���C���[�̃J���[�ԍ�

    // Start is called before the first frame update
    void Start()
    {
        ColorCounter.MassCount(pPos[0],pPos[1], ColorNum);//Player�̏����ʒu���L�^
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickUpArrow()//��Ɉړ�
    {
            playerPos = this.player.transform.position;//Player�̍��W�擾
                                                       //���݂̍��W����Y+1�̍��W��1�b�����Ĉړ�
            this.player.transform.DOMove(new Vector3(playerPos.x, playerPos.y + 1, 0), 1f);
            playerPos = this.player.transform.position;//Player�̍��W�X�V

            pPos[1]--;//�v���C���[�̈ʒu���X�V
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);//�v���C���[�̈ʒu�̎擾�A�J���[�ԍ��̐ݒ�
            count++;
    }

    public void ClickDownArrow() //���Ɉړ�
    {
            playerPos = this.player.transform.position;
            //���݂̍��W����Y-1�̍��W��1�b�����Ĉړ�
            this.player.transform.DOMove(new Vector3(playerPos.x, playerPos.y - 1, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[1]++;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
    }

    public void ClickRightArrow()//�E�Ɉړ�
    {
            playerPos = this.player.transform.position;
            //���݂̍��W����x+1�̍��W��1�b�����Ĉړ�
            this.player.transform.DOMove(new Vector3(playerPos.x + 1, playerPos.y, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[0]++;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
            
    }

    public void ClickLeftArrow()//���Ɉړ�
    {
            playerPos = this.player.transform.position;
            //���݂̍��W����x-1�̍��W��1�b�����Ĉړ�
            this.player.transform.DOMove(new Vector3(playerPos.x - 1, playerPos.y, 0), 1f);
            playerPos = this.player.transform.position;

            pPos[0]--;
            ColorCounter.MassCount(pPos[0], pPos[1], ColorNum);
            count++;
    }
}

//�{�^����������񐔂���������ȂǂŎ擾
//���̌�AButtonClick�ϐ��ŃJ�E���g
//ButtonClick=0��false
