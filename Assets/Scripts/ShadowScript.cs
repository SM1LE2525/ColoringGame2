//Shadow�ɃA�^�b�`
//�A�j���[�V�����ŃT�C�R���̉e��\�����鏈��

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScript : MonoBehaviour
{
    public Animator Sanim; //Animator�^�̕ϐ����쐬
    // Start is called before the first frame update
    void Start()
    {
        Sanim = gameObject.GetComponent<Animator>();
    }

    public void ShadowAnim() 
    {
        StartCoroutine(ShadowCoroutine());
    }

    private IEnumerator ShadowCoroutine() 
    {
        Sanim.SetBool("Clickflag", true);
        yield return new WaitForSeconds(1.7f);
        this.gameObject.SetActive(false);//"Shadow"��\��
    }
}