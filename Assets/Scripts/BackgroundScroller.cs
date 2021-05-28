using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Header("�w�i�X�N���[���������X�N���[���̑��x")]
    public float scrollSpeed = 0.01f;
    [Header("�w�i�摜�̏I���n�_")]
    public float stopPosition = -16f;
    [Header("�w�i�摜�̊J�n�n�_")]
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
