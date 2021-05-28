using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Header("背景スクロール＝強制スクロールの速度")]
    public float scrollSpeed = 0.01f;
    [Header("背景画像の終了地点")]
    public float stopPosition = -16f;
    [Header("背景画像の開始地点")]
    public float restartPosition = 5.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-scrollSpeed, 0, 0);
        if (transform.position.x < stopPosition)
        {
            transform.position = new Vector2(restartPosition, 0);
        }
    }
}
