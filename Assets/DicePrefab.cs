//EventManager�ɃA�^�b�`
//DiceObject�𐶐�����

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DicePrefab : MonoBehaviour
{
    public bool Createflag = true;//�^�[���̎n�߂��ǂ����m�F����t���O
    public GameObject DiceObject;//"DiceObject"��Prefab���i�[
    public GameObject canvas;//�\�������邽�߂�Canvas���i�[
    void Start()
    {

    }

    void Update()
    {
        if (Createflag == true)
        {
            //�v���n�u�����ƂɃI�u�W�F�N�g�𐶐�
            GameObject DiceObject_clone = (GameObject)Instantiate(DiceObject, Vector3.zero, Quaternion.identity);
            //Canvas�̎q�I�u�W�F�N�g�ɐݒ�
            DiceObject_clone.transform.SetParent(canvas.transform, false);
            Createflag = false;
        }
    }
}
