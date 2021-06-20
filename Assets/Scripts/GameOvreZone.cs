using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOvreZone : MonoBehaviour
{
    [SerializeField]
    private AudioManager audioManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().GameOver();
            Debug.Log("GameOver");
            StartCoroutine(audioManager.PlayBGM(3));
        }
    }
}
