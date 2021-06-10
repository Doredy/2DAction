using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSwitcher : MonoBehaviour
{
    private string player = "Player";

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == player)
        {
            col.transform.SetParent(transform);
        }
    }
    // Start is called before the first frame update
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == player)
        {
            collision.transform.SetParent(null);
        }
    }
}
