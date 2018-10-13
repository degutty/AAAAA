using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour 
{
    GameObject _obj;

    // Use this for initialization
    void Start () 
    {
        _obj = GameObject.Find("red");
    }
	
	// Update is called once per frame
	void Update () 
    {

        if (TouchManager.IsTouchObject(_obj))
        {
            // タッチされた時の処理

        }

    }

    /// <summary>
    /// 該当オブジェクトがタッチされたか判定.
    /// </summary>
    /// <param name="aObject">該当オブジェクト情報</param>
    /// <returns>タッチされたか</returns>
    public static bool IsTouchObject(GameObject aObject)
    {
        int srcId = aObject.gameObject.GetInstanceID();
        for (int i = 0; i < Input.touchCount; ++i)
        {
            Touch touch = Input.touches[i];
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
                Collider2D[] colliders = Physics2D.OverlapPointAll(pos);
                foreach (Collider2D collider in colliders)
                {
                    int dstId = collider.gameObject.GetInstanceID();
                    if (srcId == dstId)
                    {
                        Debug.Log("touch object name : " + aObject.gameObject.name);
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
