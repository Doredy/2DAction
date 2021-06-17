using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GoalChecker : MonoBehaviour
{
    public float moveSpeed = 0.01f;
    private float stopPos = 6.5f;
    private bool isGoal;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > stopPos)
        {
            transform.position += new Vector3(-moveSpeed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isGoal == false)
        {
            isGoal = true;
            Debug.Log("ÉQÅ[ÉÄÉNÉäÉA");
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.uiManager.GenerateResultPopUp(playerController.coinPoint);
        }
    }
}
