//�e�}�X�I�u�W�F�N�g�ɃA�^�b�`
//�}�X�̐F��ύX���鏈��

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.gameObject.name == "1P")
        {
            //�}�X�̐F���v���C���[�J���[�ɕύX
            this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color32(69, 166, 219, 255);
        }
        else if (col.gameObject.name == "2P")
        {
            //�}�X�̐F���v���C���[�J���[�ɕύX
            this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color32(236, 101, 101, 255);
        }
        else if (col.gameObject.name == "3P")
        {
            //�}�X�̐F���v���C���[�J���[�ɕύX
            this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color32(101, 236, 108, 255);
        }
        else if (col.gameObject.name == "4P")
        {
            //�}�X�̐F���v���C���[�J���[�ɕύX
            this.gameObject.GetComponent<SpriteRenderer>().material.color = new Color32(239, 174, 24, 255);
        }
    }
}
