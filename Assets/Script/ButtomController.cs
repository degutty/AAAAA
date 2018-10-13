using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtomController : MonoBehaviour 
{
    public GameObject bullet;
    public GameObject pl;

    // Use this for initialization
    void Start () 
    {
        bullet = GameObject.FindGameObjectWithTag("bullet");
        pl = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () 
    {
	}

    void OnMouseDown()
    {
        // ボタン動く
        iTween.PunchScale(this.gameObject, iTween.Hash( "x", 0.3f, "y", 0.3f, "time", 0.5));

        // 弾を飛ばす
        Vector3 plPosition = pl.transform.position;
        Vector3 force = new Vector3(plPosition.x, plPosition.y, plPosition.z);
        bullet.GetComponent<Rigidbody2D>().AddForce(force.normalized * 2000);
    }
}
