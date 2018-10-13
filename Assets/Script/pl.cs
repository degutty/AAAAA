using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pl : MonoBehaviour 
{
    public float speed = 3.0f;
    public float x = 1.0f;
    private bool canChangeScene = false;

    public Sprite[] walk;
    int animIndex;
    public int moveTime;
    float totalTime;
    int seconds;

    // Use this for initialization
    void Start () 
    {
        animIndex = 0;
        totalTime = 0;
        seconds = 0;
    }
	
	// Update is called once per frame
	void Update () 
    {
        //// 右に動く
        //GetComponent<Rigidbody2D>().velocity = 
            //new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

        // 時間計測
        totalTime += Time.deltaTime;
        seconds = (int)totalTime;

        // アニメーション
        if (seconds == moveTime)
        {
            animIndex++;
            totalTime = 0;
            if (animIndex >= walk.Length)
            {
                animIndex = 0;
            }
            GetComponent<SpriteRenderer>().sprite = walk[animIndex];
        }

        iTween.MoveBy(gameObject, iTween.Hash("x", x, "time", speed));
        iTween.MoveAdd(gameObject, iTween.Hash("y", 0.05f, "time", 0.5f, "looptype", "pingpong"));

        // 画面内に写ったことがある && 画面外に出た
        if (canChangeScene && !GetComponent<Renderer>().isVisible)
        {
            // タイトル遷移
            SceneManager.LoadScene("02_title");
        }
    }

    void OnBecameVisible()
    {
        canChangeScene = true;
    }
}
