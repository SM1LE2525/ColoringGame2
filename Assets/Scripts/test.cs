//テスト用スクリプト
//いろんな処理を試す

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class test : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click() 
    {
        //this.transform.DOMove(new Vector2(10f, 2f), 3f);
        gameObject.GetComponent<Rigidbody>().DOMove(new Vector2(10f, 2f), 3f);
    }
}
