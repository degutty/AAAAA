using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPl : MonoBehaviour 
{
    public float speed = 2;
    Vector2 vec;

    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        // クリック
        if (Input.GetMouseButtonDown(0))
        {
            vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 diff = (Vector2)this.transform.position - vec;
            Debug.Log("x=" + diff.x + " y=" + diff.y);

            if (diff.x > 0)
            {
                // 左向き
            }
            else if (diff.x < 0)
            {
                // 右向き
            }
        }

        // 歩いていく
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(vec.x, vec.y), speed * Time.deltaTime);

        // HP0になったら倒れたい

        // 一号車にたどり着いた
        // 時間切れ
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // ぶつかった
        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
        }
        else
        {
            //それ以外の処理
        }
    }
}
