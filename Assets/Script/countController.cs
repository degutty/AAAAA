using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countController : MonoBehaviour
{
    public Text Number;

    public float totalTime;
    int seconds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        Number.text = seconds.ToString();

        // 残り時間0秒
        if (seconds == 0)
        {
            // タイトル遷移
            SceneManager.LoadScene("03_music");
        }
    }
}