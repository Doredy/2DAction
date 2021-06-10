using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChecker : MonoBehaviour
{
    private MoveObject moveObject;

    private void Start()
    {
        moveObject = GetComponent<MoveObject>();
    }
    public void SetlnitialSpeed()
    {
        moveObject.moveSpeed = 0.005f;
    }
}
