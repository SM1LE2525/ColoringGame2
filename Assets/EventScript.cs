//EventManager�ɃA�^�b�`
//�Q�[���̐i�s���Ǘ�����X�N���v�g

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
        print("�Q�[�����n�߂鏇�Ԃ����߂Ă�������");
        yield return new WaitForSeconds(1.0f);
        print("�Q�[���X�^�[�g");
        yield return new WaitForSeconds(1.0f);
        print("�T�C�R����U���Ă�������");
        DiceObject.gameObject.SetActive(true);

    }
}


//�v���C���[�̏��Ԃ����߂�/*���*/
//���x���̕\���A�A�j���[�V����
//�T�C�R���̕\���E��\��
//�e�v���C���[�ւ̑��슄�蓖��

